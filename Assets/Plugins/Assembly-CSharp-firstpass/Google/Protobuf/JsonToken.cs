using System;

namespace Google.Protobuf
{
	internal sealed class JsonToken : IEquatable<JsonToken>
	{
		internal enum TokenType
		{
			Null = 0,
			False = 1,
			True = 2,
			StringValue = 3,
			Number = 4,
			Name = 5,
			StartObject = 6,
			EndObject = 7,
			StartArray = 8,
			EndArray = 9,
			EndDocument = 10
		}

		private static readonly JsonToken _true;

		private static readonly JsonToken _false;

		private static readonly JsonToken _null;

		private static readonly JsonToken startObject;

		private static readonly JsonToken endObject;

		private static readonly JsonToken startArray;

		private static readonly JsonToken endArray;

		private static readonly JsonToken endDocument;

		private readonly TokenType type;

		private readonly string stringValue;

		private readonly double numberValue;

		internal static JsonToken Null
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken False
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken True
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken StartObject
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken EndObject
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken StartArray
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken EndArray
		{
			get
			{
				return null;
			}
		}

		internal static JsonToken EndDocument
		{
			get
			{
				return null;
			}
		}

		internal TokenType Type
		{
			get
			{
				return default(TokenType);
			}
		}

		internal string StringValue
		{
			get
			{
				return null;
			}
		}

		internal double NumberValue
		{
			get
			{
				return 0.0;
			}
		}

		private JsonToken(TokenType type, string stringValue = null, double numberValue = 0.0)
		{
		}

		internal static JsonToken Name(string name)
		{
			return null;
		}

		internal static JsonToken Value(string value)
		{
			return null;
		}

		internal static JsonToken Value(double value)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(JsonToken other)
		{
			return false;
		}
	}
}
