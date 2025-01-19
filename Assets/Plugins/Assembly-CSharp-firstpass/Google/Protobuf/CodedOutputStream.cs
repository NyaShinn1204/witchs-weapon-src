using System;
using System.IO;
using System.Text;

namespace Google.Protobuf
{
	public sealed class CodedOutputStream : IDisposable
	{
		public sealed class OutOfSpaceException : IOException
		{
			internal OutOfSpaceException()
			{
			}
		}

		private const int LittleEndian64Size = 8;

		private const int LittleEndian32Size = 4;

		internal static readonly Encoding Utf8Encoding;

		public static readonly int DefaultBufferSize;

		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private readonly int limit;

		private int position;

		private readonly Stream output;

		public long Position
		{
			get
			{
				return 0L;
			}
		}

		public int SpaceLeft
		{
			get
			{
				return 0;
			}
		}

		public CodedOutputStream(byte[] flatArray)
		{
		}

		private CodedOutputStream(byte[] buffer, int offset, int length)
		{
		}

		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen)
		{
		}

		public CodedOutputStream(Stream output)
		{
		}

		public CodedOutputStream(Stream output, int bufferSize)
		{
		}

		public CodedOutputStream(Stream output, bool leaveOpen)
		{
		}

		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen)
		{
		}

		public static int ComputeDoubleSize(double value)
		{
			return 0;
		}

		public static int ComputeFloatSize(float value)
		{
			return 0;
		}

		public static int ComputeUInt64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeInt64Size(long value)
		{
			return 0;
		}

		public static int ComputeInt32Size(int value)
		{
			return 0;
		}

		public static int ComputeFixed64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeFixed32Size(uint value)
		{
			return 0;
		}

		public static int ComputeBoolSize(bool value)
		{
			return 0;
		}

		public static int ComputeStringSize(string value)
		{
			return 0;
		}

		public static int ComputeGroupSize(IMessage value)
		{
			return 0;
		}

		public static int ComputeMessageSize(IMessage value)
		{
			return 0;
		}

		public static int ComputeBytesSize(ByteString value)
		{
			return 0;
		}

		public static int ComputeUInt32Size(uint value)
		{
			return 0;
		}

		public static int ComputeEnumSize(int value)
		{
			return 0;
		}

		public static int ComputeSFixed32Size(int value)
		{
			return 0;
		}

		public static int ComputeSFixed64Size(long value)
		{
			return 0;
		}

		public static int ComputeSInt32Size(int value)
		{
			return 0;
		}

		public static int ComputeSInt64Size(long value)
		{
			return 0;
		}

		public static int ComputeLengthSize(int length)
		{
			return 0;
		}

		public static int ComputeRawVarint32Size(uint value)
		{
			return 0;
		}

		public static int ComputeRawVarint64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeTagSize(int fieldNumber)
		{
			return 0;
		}

		public void WriteDouble(double value)
		{
		}

		public void WriteFloat(float value)
		{
		}

		public void WriteUInt64(ulong value)
		{
		}

		public void WriteInt64(long value)
		{
		}

		public void WriteInt32(int value)
		{
		}

		public void WriteFixed64(ulong value)
		{
		}

		public void WriteFixed32(uint value)
		{
		}

		public void WriteBool(bool value)
		{
		}

		public void WriteString(string value)
		{
		}

		public void WriteMessage(IMessage value)
		{
		}

		public void WriteBytes(ByteString value)
		{
		}

		public void WriteUInt32(uint value)
		{
		}

		public void WriteEnum(int value)
		{
		}

		public void WriteSFixed32(int value)
		{
		}

		public void WriteSFixed64(long value)
		{
		}

		public void WriteSInt32(int value)
		{
		}

		public void WriteSInt64(long value)
		{
		}

		public void WriteLength(int length)
		{
		}

		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
		}

		public void WriteTag(uint tag)
		{
		}

		public void WriteRawTag(byte b1)
		{
		}

		public void WriteRawTag(byte b1, byte b2)
		{
		}

		public void WriteRawTag(byte b1, byte b2, byte b3)
		{
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4)
		{
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5)
		{
		}

		internal void WriteRawVarint32(uint value)
		{
		}

		internal void WriteRawVarint64(ulong value)
		{
		}

		internal void WriteRawLittleEndian32(uint value)
		{
		}

		internal void WriteRawLittleEndian64(ulong value)
		{
		}

		internal void WriteRawByte(byte value)
		{
		}

		internal void WriteRawByte(uint value)
		{
		}

		internal void WriteRawBytes(byte[] value)
		{
		}

		internal void WriteRawBytes(byte[] value, int offset, int length)
		{
		}

		internal static uint EncodeZigZag32(int n)
		{
			return 0u;
		}

		internal static ulong EncodeZigZag64(long n)
		{
			return 0uL;
		}

		private void RefreshBuffer()
		{
		}

		public void Dispose()
		{
		}

		public void Flush()
		{
		}

		public void CheckNoSpaceLeft()
		{
		}
	}
}
