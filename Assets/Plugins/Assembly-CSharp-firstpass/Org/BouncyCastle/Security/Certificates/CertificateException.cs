using System;

namespace Org.BouncyCastle.Security.Certificates
{
	[Serializable]
	public class CertificateException : GeneralSecurityException
	{
		public CertificateException()
		{
		}

		public CertificateException(string message)
		{
		}

		public CertificateException(string message, Exception exception)
		{
		}
	}
}
