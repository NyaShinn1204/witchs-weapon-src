using System;

namespace Org.BouncyCastle.Security
{
	[Serializable]
	public class KeyException : GeneralSecurityException
	{
		public KeyException()
		{
		}

		public KeyException(string message)
		{
		}

		public KeyException(string message, Exception exception)
		{
		}
	}
}
