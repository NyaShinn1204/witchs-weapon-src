using System;

namespace Org.BouncyCastle.Security.Certificates
{
	[Serializable]
	public class CrlException : GeneralSecurityException
	{
		public CrlException()
		{
		}

		public CrlException(string msg)
		{
		}

		public CrlException(string msg, Exception e)
		{
		}
	}
}
