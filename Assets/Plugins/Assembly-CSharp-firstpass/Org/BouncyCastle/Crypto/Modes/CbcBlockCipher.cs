namespace Org.BouncyCastle.Crypto.Modes
{
	public class CbcBlockCipher : IBlockCipher
	{
		private byte[] IV;

		private byte[] cbcV;

		private byte[] cbcNextV;

		private int blockSize;

		private IBlockCipher cipher;

		private bool encrypting;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		public CbcBlockCipher(IBlockCipher cipher)
		{
		}

		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int GetBlockSize()
		{
			return 0;
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		public void Reset()
		{
		}

		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}
	}
}
