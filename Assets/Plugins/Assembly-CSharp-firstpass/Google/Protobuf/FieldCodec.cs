using System;
using System.Collections.Generic;

namespace Google.Protobuf
{
	public static class FieldCodec
	{
		private static class WrapperCodecs
		{
			private static readonly Dictionary<Type, object> Codecs;

			internal static FieldCodec<T> GetCodec<T>()
			{
				return null;
			}

			internal static T Read<T>(CodedInputStream input, FieldCodec<T> codec)
			{
				return default(T);
			}

			internal static void Write<T>(CodedOutputStream output, T value, FieldCodec<T> codec)
			{
			}

			internal static int CalculateSize<T>(T value, FieldCodec<T> codec)
			{
				return 0;
			}
		}

		public static FieldCodec<string> ForString(uint tag)
		{
			return null;
		}

		public static FieldCodec<ByteString> ForBytes(uint tag)
		{
			return null;
		}

		public static FieldCodec<bool> ForBool(uint tag)
		{
			return null;
		}

		public static FieldCodec<int> ForInt32(uint tag)
		{
			return null;
		}

		public static FieldCodec<int> ForSInt32(uint tag)
		{
			return null;
		}

		public static FieldCodec<uint> ForFixed32(uint tag)
		{
			return null;
		}

		public static FieldCodec<int> ForSFixed32(uint tag)
		{
			return null;
		}

		public static FieldCodec<uint> ForUInt32(uint tag)
		{
			return null;
		}

		public static FieldCodec<long> ForInt64(uint tag)
		{
			return null;
		}

		public static FieldCodec<long> ForSInt64(uint tag)
		{
			return null;
		}

		public static FieldCodec<ulong> ForFixed64(uint tag)
		{
			return null;
		}

		public static FieldCodec<long> ForSFixed64(uint tag)
		{
			return null;
		}

		public static FieldCodec<ulong> ForUInt64(uint tag)
		{
			return null;
		}

		public static FieldCodec<float> ForFloat(uint tag)
		{
			return null;
		}

		public static FieldCodec<double> ForDouble(uint tag)
		{
			return null;
		}

		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32)
		{
			return null;
		}

		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : IMessage<T>
		{
			return null;
		}

		public static FieldCodec<T> ForClassWrapper<T>(uint tag) where T : class
		{
			return null;
		}

		public static FieldCodec<T?> ForStructWrapper<T>(uint tag) where T : struct
		{
			return null;
		}
	}
	public sealed class FieldCodec<T>
	{
		private static readonly T DefaultDefault;

		private static readonly bool TypeSupportsPacking;

		internal readonly bool PackedRepeatedField;

		internal readonly Action<CodedOutputStream, T> ValueWriter;

		internal readonly Func<T, int> ValueSizeCalculator;

		internal readonly Func<CodedInputStream, T> ValueReader;

		internal readonly int FixedSize;

		internal readonly uint Tag;

		internal readonly T DefaultValue;

		private readonly int tagSize;

		static FieldCodec()
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag)
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag)
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue)
		{
		}

		internal static bool IsPackedRepeatedField(uint tag)
		{
			return false;
		}

		public void WriteTagAndValue(CodedOutputStream output, T value)
		{
		}

		public T Read(CodedInputStream input)
		{
			return default(T);
		}

		public int CalculateSizeWithTag(T value)
		{
			return 0;
		}

		private bool IsDefault(T value)
		{
			return false;
		}
	}
}
