using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonReader
	{
		internal static readonly string LiteralFalse;

		internal static readonly string LiteralTrue;

		internal static readonly string LiteralNull;

		internal static readonly string LiteralUndefined;

		internal static readonly string LiteralNotANumber;

		internal static readonly string LiteralPositiveInfinity;

		internal static readonly string LiteralNegativeInfinity;

		internal static readonly string TypeGenericIDictionary;

		private readonly JsonReaderSettings Settings;

		private readonly string Source;

		private readonly int SourceLength;

		private int index;

		private readonly List<object> previouslyDeserialized;

		private readonly Stack<List<object>> jsArrays;

		public JsonReader(string input, JsonReaderSettings settings)
		{
		}

		public object Deserialize(Type type)
		{
			return null;
		}

		private object Read(Type expectedType, bool typeIsHint)
		{
			return null;
		}

		public void PopulateObject<T>(ref T obj) where T : class
		{
		}

		public void PopulateObject(ref object obj)
		{
		}

		private object ReadObject(Type objectType)
		{
			return null;
		}

		private Type GetGenericDictionaryType(Type objectType)
		{
			return null;
		}

		private void PopulateObject(ref object result, Type objectType, Dictionary<string, MemberInfo> memberMap, Type genericDictionaryType)
		{
		}

		private IEnumerable ReadArray(Type arrayType)
		{
			return null;
		}

		private string ReadUnquotedKey()
		{
			return null;
		}

		private object ReadString(Type expectedType)
		{
			return null;
		}

		private object ReadNumber(Type expectedType)
		{
			return null;
		}

		private JsonToken Tokenize()
		{
			return default(JsonToken);
		}

		private JsonToken Tokenize(bool allowUnquotedString)
		{
			return default(JsonToken);
		}

		private bool MatchLiteral(string literal)
		{
			return false;
		}
	}
}
