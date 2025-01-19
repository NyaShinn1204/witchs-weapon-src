using System.Collections.Generic;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsData
	{
		private object _value;

		public static readonly fsData True;

		public static readonly fsData False;

		public static readonly fsData Null;

		public fsDataType Type
		{
			get
			{
				return default(fsDataType);
			}
		}

		public bool IsNull
		{
			get
			{
				return false;
			}
		}

		public bool IsDouble
		{
			get
			{
				return false;
			}
		}

		public bool IsInt64
		{
			get
			{
				return false;
			}
		}

		public bool IsBool
		{
			get
			{
				return false;
			}
		}

		public bool IsString
		{
			get
			{
				return false;
			}
		}

		public bool IsDictionary
		{
			get
			{
				return false;
			}
		}

		public bool IsList
		{
			get
			{
				return false;
			}
		}

		public double AsDouble
		{
			get
			{
				return 0.0;
			}
		}

		public long AsInt64
		{
			get
			{
				return 0L;
			}
		}

		public bool AsBool
		{
			get
			{
				return false;
			}
		}

		public string AsString
		{
			get
			{
				return null;
			}
		}

		public Dictionary<string, fsData> AsDictionary
		{
			get
			{
				return null;
			}
		}

		public List<fsData> AsList
		{
			get
			{
				return null;
			}
		}

		public fsData()
		{
		}

		public fsData(bool boolean)
		{
		}

		public fsData(double f)
		{
		}

		public fsData(long i)
		{
		}

		public fsData(string str)
		{
		}

		public fsData(Dictionary<string, fsData> dict)
		{
		}

		public fsData(List<fsData> list)
		{
		}

		public static fsData CreateDictionary()
		{
			return null;
		}

		public static fsData CreateList()
		{
			return null;
		}

		public static fsData CreateList(int capacity)
		{
			return null;
		}

		internal void BecomeDictionary()
		{
		}

		internal fsData Clone()
		{
			return null;
		}

		private T Cast<T>()
		{
			return default(T);
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(fsData other)
		{
			return false;
		}

		public static bool operator ==(fsData a, fsData b)
		{
			return false;
		}

		public static bool operator !=(fsData a, fsData b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
