using System;

namespace Org.BouncyCastle.Security.Certificates
{
	[Serializable]
	public class CertificateEncodingException : CertificateException
	{
		public CertificateEncodingException()
		{
		}

		public CertificateEncodingException(string msg)
		{
		}

		public CertificateEncodingException(string msg, Exception e)
		{
		}
	}
}
