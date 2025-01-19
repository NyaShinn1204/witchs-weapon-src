using System;
using System.IO;

namespace Google.Protobuf
{
	public sealed class CodedInputStream : IDisposable
	{
		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private int bufferSize;

		private int bufferSizeAfterLimit;

		private int bufferPos;

		private readonly Stream input;

		private uint lastTag;

		private uint nextTag;

		private bool hasNextTag;

		internal const int DefaultRecursionLimit = 64;

		internal const int DefaultSizeLimit = 67108864;

		internal const int BufferSize = 4096;

		private int totalBytesRetired;

		private int currentLimit;

		private int recursionDepth;

		private readonly int recursionLimit;

		private readonly int sizeLimit;

		public long Position
		{
			get
			{
				return 0L;
			}
		}

		internal uint LastTag
		{
			get
			{
				return 0u;
			}
		}

		public int SizeLimit
		{
			get
			{
				return 0;
			}
		}

		public int RecursionLimit
		{
			get
			{
				return 0;
			}
		}

		internal bool ReachedLimit
		{
			get
			{
				return false;
			}
		}

		public bool IsAtEnd
		{
			get
			{
				return false;
			}
		}

		public CodedInputStream(byte[] buffer)
		{
		}

		public CodedInputStream(byte[] buffer, int offset, int length)
		{
		}

		public CodedInputStream(Stream input)
		{
		}

		public CodedInputStream(Stream input, bool leaveOpen)
		{
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize)
		{
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit)
		{
		}

		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit)
		{
			return null;
		}

		public void Dispose()
		{
		}

		internal void CheckReadEndOfStreamTag()
		{
		}

		public uint PeekTag()
		{
			return 0u;
		}

		public uint ReadTag()
		{
			return 0u;
		}

		public void SkipLastField()
		{
		}

		private void SkipGroup(uint startGroupTag)
		{
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public ulong ReadUInt64()
		{
			return 0uL;
		}

		public long ReadInt64()
		{
			return 0L;
		}

		public int ReadInt32()
		{
			return 0;
		}

		public ulong ReadFixed64()
		{
			return 0uL;
		}

		public uint ReadFixed32()
		{
			return 0u;
		}

		public bool ReadBool()
		{
			return false;
		}

		public string ReadString()
		{
			return null;
		}

		public void ReadMessage(IMessage builder)
		{
		}

		public ByteString ReadBytes()
		{
			return null;
		}

		public uint ReadUInt32()
		{
			return 0u;
		}

		public int ReadEnum()
		{
			return 0;
		}

		public int ReadSFixed32()
		{
			return 0;
		}

		public long ReadSFixed64()
		{
			return 0L;
		}

		public int ReadSInt32()
		{
			return 0;
		}

		public long ReadSInt64()
		{
			return 0L;
		}

		public int ReadLength()
		{
			return 0;
		}

		public bool MaybeConsumeTag(uint tag)
		{
			return false;
		}

		private uint SlowReadRawVarint32()
		{
			return 0u;
		}

		internal uint ReadRawVarint32()
		{
			return 0u;
		}

		internal static uint ReadRawVarint32(Stream input)
		{
			return 0u;
		}

		internal ulong ReadRawVarint64()
		{
			return 0uL;
		}

		internal uint ReadRawLittleEndian32()
		{
			return 0u;
		}

		internal ulong ReadRawLittleEndian64()
		{
			return 0uL;
		}

		internal static int DecodeZigZag32(uint n)
		{
			return 0;
		}

		internal static long DecodeZigZag64(ulong n)
		{
			return 0L;
		}

		internal int PushLimit(int byteLimit)
		{
			return 0;
		}

		private void RecomputeBufferSizeAfterLimit()
		{
		}

		internal void PopLimit(int oldLimit)
		{
		}

		private bool RefillBuffer(bool mustSucceed)
		{
			return false;
		}

		internal byte ReadRawByte()
		{
			return 0;
		}

		internal byte[] ReadRawBytes(int size)
		{
			return null;
		}

		private void SkipRawBytes(int size)
		{
		}

		private void SkipImpl(int amountToSkip)
		{
		}
	}
}
