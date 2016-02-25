﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Gammtek.Conduit.Extensions;
using Gammtek.Conduit.Extensions.Collections.Generic;

namespace Gammtek.Conduit.MassEffect.Coalesce.Xml
{
	public class XmlCoalesceAsset : CoalesceAsset
	{
		//private static readonly Regex WhitespacePattern = new Regex(@"\s+", RegexOptions.Compiled);
		private static readonly Regex SpecialCharactersPattern = new Regex(@"[\r\n\t]+", RegexOptions.Compiled);

		public XmlCoalesceAsset(string name = "", CoalesceSections sections = null, IList<CoalesceInclude> includes = null)
			: base(name, sections)
		{
			Includes = includes ?? new List<CoalesceInclude>();
		}

		public string BaseUri { get; protected set; }

		public IList<CoalesceInclude> Includes { get; set; }

		public string LogicalSourcePath { get; protected set; }

		public string SourceDirectory { get; protected set; }

		public string SourcePath { get; protected set; }

		public static XmlCoalesceAsset Load(string path)
		{
			if (path.IsNullOrEmpty())
			{
				throw new ArgumentNullException("path");
			}

			var sourcePath = Path.GetFullPath(path);

			if (!File.Exists(sourcePath))
			{
				Console.WriteLine(@"Warning: {0} not found!", path);
				return null;
			}

			var doc = XDocument.Load(path);

			var root = doc.Root;

			if (root == null)
			{
				return null;
			}

			var id = (string) root.Attribute("id");
			var name = (string) root.Attribute("name");
			var source = (string) root.Attribute("source");

			var result = new XmlCoalesceAsset(name)
			{
				BaseUri = (doc.BaseUri != "") ? doc.BaseUri : new Uri(sourcePath).AbsoluteUri,
				Id = id,
				Source = source,
				SourcePath = sourcePath,
				SourceDirectory = Path.GetDirectoryName(sourcePath)
			};

			// Read includes before the sections
			result.ReadIncludes(root);
			result.ReadSections(root);

			return result;
		}

		public void ReadIncludes(XElement root)
		{
			if (root == null)
			{
				throw new ArgumentNullException("root");
			}

			var includesElement = root.Element("Includes");

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
				
				Includes.Add(new CoalesceInclude(sourcePath));
			}

			foreach (var include in Includes)
			{
				var asset = Load(include.Source);

				if (asset == null)
				{
					continue;
				}

				Combine(asset);
			}
		}

		public CoalesceProperty ReadProperty(XElement propertyElement)
		{
			if (propertyElement == null)
			{
				throw new ArgumentNullException("propertyElement");
			}

			var propertyName = (string) propertyElement.Attribute("name");

			if (propertyName.IsNullOrWhiteSpace())
			{
				return null;
			}

			var property = new CoalesceProperty(propertyName);

			if (propertyElement.HasElements)
			{
				var valueElements = from el in propertyElement.Elements("Value") select el;

				// Loop through the current properties values
				foreach (var valueElement in valueElements)
				{
					var value = valueElement.Value;
					var type = (int?) valueElement.Attribute("type");

					if (!value.IsNullOrWhiteSpace())
					{
						value = SpecialCharactersPattern.Replace(value.Trim(), "");
					}

					property.Add(new CoalesceValue(value, type));
				}
			}
			else
			{
				var value = propertyElement.Value;
				var type = (int?) propertyElement.Attribute("type");

				if (!value.IsNullOrWhiteSpace())
				{
					value = SpecialCharactersPattern.Replace(value.Trim(), "");
				}

				property.Add(new CoalesceValue(value, type));
			}

			return property;
		}

		public void ReadSections(XElement root)
		{
			if (root == null)
			{
				throw new ArgumentNullException("root");
			}

			var sectionsElement = root.Element("Sections");

			if (sectionsElement == null)
			{
				return;
			}

			var sectionElements = from el in sectionsElement.Elements("Section") select el;

			// Loop through the sections
			foreach (var sectionElement in sectionElements)
			{
				CoalesceSection section;
				var currentSection = new CoalesceSection();
				var sectionName = (string) sectionElement.Attribute("name");

				// Make sure the section has a name
				if (sectionName.IsNullOrEmpty())
				{
					continue;
				}

				var propertyElements = from el in sectionElement.Elements("Property") select el;

				// Loop through the current sections properties
				foreach (var propertyElement in propertyElements)
				{
					var currentProperty = ReadProperty(propertyElement);
					CoalesceProperty property;

					if (currentProperty == null)
					{
						continue;
					}

					if (!currentSection.TryGetValue(currentProperty.Name, out property))
					{
						property = new CoalesceProperty();
						currentSection.Add(currentProperty.Name, property);
					}

					property.AddRange(currentProperty);
				}

				if (!Sections.TryGetValue(sectionName, out section))
				{
					section = new CoalesceSection();
					Sections.Add(sectionName, section);
				}

				section.Combine(currentSection);
			}
		}
	}
}
