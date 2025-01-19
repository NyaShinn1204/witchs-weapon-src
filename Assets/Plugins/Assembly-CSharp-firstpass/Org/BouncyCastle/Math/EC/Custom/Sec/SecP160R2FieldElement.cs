namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP160R2FieldElement : ECFieldElement
	{
		public static readonly BigInteger Q;

		protected internal readonly uint[] x;

		public override bool IsZero
		{
			get
			{
				return false;
			}
		}

		public override bool IsOne
		{
			get
			{
				return false;
			}
		}

		public override string FieldName
		{
			get
			{
				return null;
			}
		}

		public override int FieldSize
		{
			get
			{
				return 0;
			}
		}

		public SecP160R2FieldElement(BigInteger x)
		{
		}

		public SecP160R2FieldElement()
		{
		}

		protected internal SecP160R2FieldElement(uint[] x)
		{
		}

		public override bool TestBitZero()
		{
			return false;
		}

		public override BigInteger ToBigInteger()
		{
			return null;
		}

		public override ECFieldElement Add(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement AddOne()
		{
			return null;
		}

		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement Multiply(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement Divide(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement Negate()
		{
			return null;
		}

		public override ECFieldElement Square()
		{
			return null;
		}

		public override ECFieldElement Invert()
		{
			return null;
		}

		public override ECFieldElement Sqrt()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override bool Equals(ECFieldElement other)
		{
			return false;
		}

		public virtual bool Equals(SecP160R2FieldElement other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
