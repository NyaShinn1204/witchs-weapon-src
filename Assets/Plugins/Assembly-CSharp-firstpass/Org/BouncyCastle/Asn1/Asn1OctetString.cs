using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public abstract class Asn1OctetString : Asn1Object, Asn1OctetStringParser, IAsn1Convertible
	{
		internal byte[] str;

		public Asn1OctetStringParser Parser
		{
			get
			{
				return null;
			}
		}

		internal Asn1OctetString(byte[] str)
		{
		}

		internal Asn1OctetString(Asn1Encodable obj)
		{
		}

		public static Asn1OctetString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public static Asn1OctetString GetInstance(object obj)
		{
			return null;
		}

		public Stream GetOctetStream()
		{
			return null;
		}

		public virtual byte[] GetOctets()
		{
			return null;
		}

		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
