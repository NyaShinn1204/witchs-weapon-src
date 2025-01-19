namespace Ionic.Crc
{
	public class CRC32
	{
		private uint dwPolynomial;

		private long _TotalBytesRead;

		private bool reverseBits;

		private uint[] crc32Table;

		private uint _register;

		public long TotalBytesRead
		{
			get
			{
				return 0L;
			}
		}

		public int Crc32Result
		{
			get
			{
				return 0;
			}
		}

		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		private static uint ReverseBits(uint data)
		{
			return 0u;
		}

		private static byte ReverseBits(byte data)
		{
			return 0;
		}

		private void GenerateLookupTable()
		{
		}

		public CRC32()
		{
		}

		public CRC32(bool reverseBits)
		{
		}

		public CRC32(int polynomial, bool reverseBits)
		{
		}
	}
}
