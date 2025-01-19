using System.IO;
using LuaInterface;

namespace LuaFramework
{
	public class ByteBuffer
	{
		private MemoryStream stream;

		private BinaryWriter writer;

		private BinaryReader reader;

		public ByteBuffer()
		{
		}

		public ByteBuffer(byte[] data)
		{
		}

		public void Close()
		{
		}

		public void WriteByte(byte v)
		{
		}

		public void WriteInt(int v)
		{
		}

		public void WriteShort(ushort v)
		{
		}

		public void WriteLong(long v)
		{
		}

		public void WriteFloat(float v)
		{
		}

		public void WriteDouble(double v)
		{
		}

		public void WriteString(string v)
		{
		}

		public void WriteBytes(byte[] v)
		{
		}

		public void WriteBuffer(LuaByteBuffer strBuffer)
		{
		}

		public byte ReadByte()
		{
			return 0;
		}

		public int ReadInt()
		{
			return 0;
		}

		public ushort ReadShort()
		{
			return 0;
		}

		public long ReadLong()
		{
			return 0L;
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public string ReadString()
		{
			return null;
		}

		public byte[] ReadBytes()
		{
			return null;
		}

		public LuaByteBuffer ReadBuffer(byte[] data)
		{
			return default(LuaByteBuffer);
		}

		public LuaByteBuffer ReadBuffer()
		{
			return default(LuaByteBuffer);
		}

		public byte[] ToBytes()
		{
			return null;
		}

		public void Flush()
		{
		}
	}
}
