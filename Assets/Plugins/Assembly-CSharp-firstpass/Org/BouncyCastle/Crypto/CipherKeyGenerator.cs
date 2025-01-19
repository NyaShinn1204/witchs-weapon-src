using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	public class CipherKeyGenerator
	{
		protected internal SecureRandom random;

		protected internal int strength;

		private bool uninitialised;

		private int defaultStrength;

		public int DefaultStrength
		{
			get
			{
				return 0;
			}
		}

		public CipherKeyGenerator()
		{
		}

		internal CipherKeyGenerator(int defaultStrength)
		{
		}

		public void Init(KeyGenerationParameters parameters)
		{
		}

		protected virtual void engineInit(KeyGenerationParameters parameters)
		{
		}

		public byte[] GenerateKey()
		{
			return null;
		}

		protected virtual byte[] engineGenerateKey()
		{
			return null;
		}
	}
}
