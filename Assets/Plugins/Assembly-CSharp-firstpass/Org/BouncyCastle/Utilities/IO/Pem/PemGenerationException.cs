using System;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	[Serializable]
	public class PemGenerationException : Exception
	{
		public PemGenerationException()
		{
		}

		public PemGenerationException(string message)
		{
		}

		public PemGenerationException(string message, Exception exception)
		{
		}
	}
}
