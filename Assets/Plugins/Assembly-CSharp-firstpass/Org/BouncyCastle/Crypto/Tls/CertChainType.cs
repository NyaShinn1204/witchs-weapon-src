namespace Org.BouncyCastle.Crypto.Tls
{
	public abstract class CertChainType
	{
		public const byte individual_certs = 0;

		public const byte pkipath = 1;

		public static bool IsValid(byte certChainType)
		{
			return false;
		}
	}
}
