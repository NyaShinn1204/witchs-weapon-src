using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.X509
{
	internal class X509SignatureUtilities
	{
		private static readonly Asn1Null derNull;

		internal static void SetSignatureParameters(ISigner signature, Asn1Encodable parameters)
		{
		}

		internal static string GetSignatureName(AlgorithmIdentifier sigAlgId)
		{
			return null;
		}

		private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
		{
			return null;
		}
	}
}
