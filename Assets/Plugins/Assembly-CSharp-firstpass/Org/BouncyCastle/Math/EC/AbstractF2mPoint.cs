namespace Org.BouncyCastle.Math.EC
{
	public abstract class AbstractF2mPoint : ECPointBase
	{
		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
			: base(null, null, null, false)
		{
		}

		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
			: base(null, null, null, false)
		{
		}

		protected override bool SatisfiesCurveEquation()
		{
			return false;
		}

		public override ECPoint ScaleX(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint ScaleY(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint Subtract(ECPoint b)
		{
			return null;
		}

		public virtual AbstractF2mPoint Tau()
		{
			return null;
		}

		public virtual AbstractF2mPoint TauPow(int pow)
		{
			return null;
		}
	}
}
