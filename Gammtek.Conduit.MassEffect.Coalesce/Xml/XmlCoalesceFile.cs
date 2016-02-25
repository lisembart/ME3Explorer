﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Gammtek.Conduit.Extensions;
using Gammtek.Conduit.IO;

namespace Gammtek.Conduit.MassEffect.Coalesce.Xml
{
	public class XmlCoalesceFile : CoalesceFile
	{
		public XmlCoalesceFile(string source = "", string name = "", string id = "", IList<CoalesceDocument> documents = null,
			CoalesceSettings settings = null, IList<XmlCoalesceInclude> includes = null, ByteOrder byteOrder = ByteOrder.LittleEndian)
			: base(source, name, id, documents, settings, byteOrder)
		{
			Includes = includes ?? new List<XmlCoalesceInclude>();
		}

		public string BaseUri { get; protected set; }

		public IList<XmlCoalesceInclude> Includes { get; set; }

		//public string LogicalSourcePath { get; protected set; }

		public string SourceDirectory { get; protected set; }

		public string SourcePath { get; protected set; }

		public static XmlCoalesceFile Load(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				throw new ArgumentNullException(nameof(path));
			}

			var sourcePath = Path.GetFullPath(path);

			if (!File.Exists(sourcePath))
			{
				return null;
			}

			var doc = XDocument.Load(path);

			var result = new XmlCoalesceFile
			{
				BaseUri = (doc.BaseUri != "") ? doc.BaseUri : new Uri(sourcePath).AbsoluteUri,
				SourcePath = sourcePath,
				SourceDirectory = Path.GetDirectoryName(sourcePath)
			};

			// Read settings before assets
			result.ReadSettings(doc);
			result.ReadAssets(doc);

			return result;
		}

		public void ReadAssets(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException(nameof(element));
			}

			var assetsElement = element.Element("Assets");

			if (assetsElement == null)
			{
				return;
			}

			var assets = from el in assetsElement.Elements("Asset") select el;
			var includes = new List<XmlCoalesceInclude>();

			foreach (var asset in assets)
			{
				var source = (string) asset.Attribute("source");

				if (source.IsNullOrEmpty())
				{
					continue;
				}

				var sourcePath = Path.Combine(SourceDirectory, source);
				sourcePath = Path.GetFullPath(sourcePath);

				includes.Add(new XmlCoalesceInclude(sourcePath));
			}

			foreach (var include in includes)
			{
				var asset = XmlCoalesceDocument.Load(include.Source);

				if (asset != null && !asset.Source.IsNullOrEmpty())
				{
					Documents.Add(asset);
				}
			}
		}

		public void ReadAssets(XDocument doc)
		{
			if (doc == null)
			{
				throw new ArgumentNullException(nameof(doc));
			}

			ReadAssets(doc.Root);
		}

		public void ReadIncludes(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException(nameof(element));
			}

			var includesElement = element.Element("Includes");

			if (includesElement == null)
			{
				return;
			}

			var includes = from el in includesElement.Elements("Include") select el;

			foreach (var include in includes)
			{
				var source = (string) include.Attribute("source");

				if (source.IsNullOrEmpty())
				{
					continue;
				}

				var sourcePath = Path.Combine(SourceDirectory, source);
				sourcePath = Path.GetFullPath(sourcePath);

				Includes.Add(new XmlCoalesceInclude(sourcePath));
			}

			foreach (var include in Includes)
			{
				var asset = XmlCoalesceDocument.Load(include.Source);

				if (!asset.Source.IsNullOrEmpty())
				{
					Documents.Add(asset);
				}
			}
		}

		public void ReadIncludes(XDocument doc)
		{
			if (doc == null)
			{
				throw new ArgumentNullException(nameof(doc));
			}

			ReadIncludes(doc.Root);
		}

		public void ReadSettings(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException(nameof(element));
			}

			var settingsElement = element.Element("Settings");

			if (settingsElement == null)
			{
				return;
			}

			var settings = from el in settingsElement.Elements("Setting") select el;

			foreach (var setting in settings)
			{
				var name = (string) setting.Attribute("name");
				var value = (string) setting.Attribute("value");

				if (name.IsNullOrEmpty())
				{
					continue;
				}

				if (value.IsNullOrEmpty())
				{
					value = setting.Value;
				}

				Settings.SetValue(name, value);
			}
		}

		public void ReadSettings(XDocument doc)
		{
			if (doc == null)
			{
				throw new ArgumentNullException(nameof(doc));
			}

			ReadSettings(doc.Root);
		}

		public void Save(string path) {}
	}
}
