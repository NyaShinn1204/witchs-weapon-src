namespace Org.BouncyCastle.Asn1
{
	public class DerSetParser : Asn1SetParser, IAsn1Convertible
	{
		private readonly Asn1StreamParser _parser;

		internal DerSetParser(Asn1StreamParser parser)
		{
		}

		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		public Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
