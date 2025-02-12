using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class BerTaggedObjectParser : Asn1TaggedObjectParser, IAsn1Convertible
	{
		private bool _constructed;

		private int _tagNumber;

		private Asn1StreamParser _parser;

		public bool IsConstructed
		{
			get
			{
				return false;
			}
		}

		public int TagNo
		{
			get
			{
				return 0;
			}
		}

		[Obsolete]
		internal BerTaggedObjectParser(int baseTag, int tagNumber, Stream contentStream)
		{
		}

		internal BerTaggedObjectParser(bool constructed, int tagNumber, Asn1StreamParser parser)
		{
		}

		public IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			return null;
		}

		public Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
