﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gammtek.Conduit.Extensions.Collections.Generic;

namespace Gammtek.Conduit.MassEffect.Coalesce
{
	public class CoalesceProperty : IList<CoalesceValue>
	{
		public const int DefaultValueType = 2;
		public const int NullValueType = 1;

		private readonly IList<CoalesceValue> _values;

		public CoalesceProperty(string name = null, IList<CoalesceValue> values = null)
		{
			_values = values ?? new List<CoalesceValue>();
			Name = name ?? "CoalesceProperty";
		}

		public int Count
		{
			get { return _values.Count; }
		}

		public bool IsReadOnly
		{
			get { return _values.IsReadOnly; }
		}

		public string Name { get; set; }

		public IDictionary<string, string> Settings { get; set; }

		public CoalesceValue this[int index]
		{
			get { return _values[index]; }
			set { _values[index] = value; }
		}

		public void Add(CoalesceValue item)
		{
			_values.Add(item);
		}

		public void Clear()
		{
			_values.Clear();
		}

		/*public void Combine(CoalesceProperty other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}

			foreach (var otherValue in other)
			{
				var value = otherValue.Value;
				var type = otherValue.ValueType;

				switch (type)
				{
					case -1: // Custom: Clear
					{
						Clear();

						break;
					}
					case 0: // New
					{
						Clear();
						Add(new CoalesceValue(value, type));

						break;
					}
					case 1: // RemoveProperty
					{
						Clear();
						Add(new CoalesceValue(value, type));

						break;
					}
					case 2: // Add
					{
						Add(new CoalesceValue(value, type));

						break;
					}
					case 3: // AddUnique
					{
						if (!this.Any(v => v.Equals(value) && v.ValueType != 4))
						{
							Add(new CoalesceValue(value, type));
						}

						break;
					}
					case 4: // Remove
					{
						this.RemoveAll(v => v.Equals(value));
						Add(new CoalesceValue(value, type));

						break;
					}
				}
			}
		}*/

		public bool Contains(CoalesceValue item)
		{
			return _values.Contains(item);
		}

		public void CopyTo(CoalesceValue[] array, int arrayIndex)
		{
			_values.CopyTo(array, arrayIndex);
		}

		public IEnumerator<CoalesceValue> GetEnumerator()
		{
			return _values.GetEnumerator();
		}

		public int IndexOf(CoalesceValue item)
		{
			return _values.IndexOf(item);
		}

		public void Insert(int index, CoalesceValue item)
		{
			_values.Insert(index, item);
		}

		public bool Remove(CoalesceValue item)
		{
			return _values.Remove(item);
		}

		public void RemoveAt(int index)
		{
			_values.RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable) _values).GetEnumerator();
		}
	}
}
