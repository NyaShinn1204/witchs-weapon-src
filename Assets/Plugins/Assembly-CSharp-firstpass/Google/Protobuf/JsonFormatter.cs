using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Google.Protobuf.Reflection;

namespace Google.Protobuf
{
	public sealed class JsonFormatter
	{
		public sealed class Settings
		{
			public static readonly Settings Default;

			public readonly bool FormatDefaultValues;

			public readonly TypeRegistry TypeRegistry;

			static Settings()
			{
			}

			public Settings(bool formatDefaultValues)
			{
			}

			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
			{
			}
		}

		private static class OriginalEnumValueHelper
		{
			private static readonly Dictionary<Type, Dictionary<object, string>> dictionaries;

			internal static string GetOriginalName(object value)
			{
				return null;
			}

			private static Dictionary<object, string> GetNameMapping(Type enumType)
			{
				return null;
			}
		}

		internal const string AnyTypeUrlField = "@type";

		internal const string AnyDiagnosticValueField = "@value";

		internal const string AnyWellKnownTypeValueField = "value";

		private const string TypeUrlPrefix = "type.googleapis.com";

		private const string NameValueSeparator = ": ";

		private const string PropertySeparator = ", ";

		public static readonly JsonFormatter Default;

		private static readonly JsonFormatter diagnosticFormatter;

		private static readonly string[] CommonRepresentations;

		private readonly Settings settings;

		private const string Hex = "0123456789abcdef";

		private bool DiagnosticOnly
		{
			get
			{
				return false;
			}
		}

		static JsonFormatter()
		{
		}

		public JsonFormatter(Settings settings)
		{
		}

		public string Format(IMessage message)
		{
			return null;
		}

		public void Format(IMessage message, TextWriter writer)
		{
		}

		public static string ToDiagnosticString(IMessage message)
		{
			return null;
		}

		private void WriteMessage(TextWriter writer, IMessage message)
		{
		}

		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten)
		{
			return false;
		}

		private static string ToCamelCaseForFieldMask(string input)
		{
			return null;
		}

		internal static string ToCamelCase(string input)
		{
			return null;
		}

		private static void WriteNull(TextWriter writer)
		{
		}

		private static bool IsDefaultValue(IFieldAccessor accessor, object value)
		{
			return false;
		}

		public void WriteValue(TextWriter writer, object value)
		{
		}

		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value)
		{
		}

		private void WriteTimestamp(TextWriter writer, IMessage value)
		{
		}

		private void WriteDuration(TextWriter writer, IMessage value)
		{
		}

		private void WriteFieldMask(TextWriter writer, IMessage value)
		{
		}

		private void WriteAny(TextWriter writer, IMessage value)
		{
		}

		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value)
		{
		}

		private void WriteStruct(TextWriter writer, IMessage message)
		{
		}

		private void WriteStructFieldValue(TextWriter writer, IMessage message)
		{
		}

		internal void WriteList(TextWriter writer, IList list)
		{
		}

		internal void WriteDictionary(TextWriter writer, IDictionary dictionary)
		{
		}

		internal static void WriteString(TextWriter writer, string text)
		{
		}

		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c)
		{
		}
	}
}
