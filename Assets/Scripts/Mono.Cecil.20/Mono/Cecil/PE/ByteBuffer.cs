namespace Mono.Cecil.PE
{
	internal class ByteBuffer
	{
		internal byte[] buffer;

		internal int length;

		internal int position;

		public ByteBuffer(byte[] buffer)
		{
		}

		public void Reset(byte[] buffer)
		{
		}

		public void Advance(int length)
		{
		}

		public byte ReadByte()
		{
			return 0;
		}

		public sbyte ReadSByte()
		{
			return 0;
		}

		public byte[] ReadBytes(int length)
		{
			return null;
		}

		public ushort ReadUInt16()
		{
			return 0;
		}

		public short ReadInt16()
		{
			return 0;
		}

		public uint ReadUInt32()
		{
			return 0u;
		}

		public int ReadInt32()
		{
			return 0;
		}

		public ulong ReadUInt64()
		{
			return 0uL;
		}

		public long ReadInt64()
		{
			return 0L;
		}

		public uint ReadCompressedUInt32()
		{
			return 0u;
		}

		public int ReadCompressedInt32()
		{
			return 0;
		}

		public float ReadSingle()
		{
			return 0f;
		}

		public double ReadDouble()
		{
			return 0.0;
		}
	}
}
