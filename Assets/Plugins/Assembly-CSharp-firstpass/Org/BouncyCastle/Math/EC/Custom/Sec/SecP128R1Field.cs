namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP128R1Field
	{
		internal static readonly uint[] P;

		internal static readonly uint[] PExt;

		private static readonly uint[] PExtInv;

		private const uint P3 = 4294967293u;

		private const uint PExt7 = 4294967292u;

		public static void Add(uint[] x, uint[] y, uint[] z)
		{
		}

		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
		}

		public static void AddOne(uint[] x, uint[] z)
		{
		}

		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		public static void Half(uint[] x, uint[] z)
		{
		}

		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
		}

		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
		}

		public static void Negate(uint[] x, uint[] z)
		{
		}

		public static void Reduce(uint[] xx, uint[] z)
		{
		}

		public static void Reduce32(uint x, uint[] z)
		{
		}

		public static void Square(uint[] x, uint[] z)
		{
		}

		public static void SquareN(uint[] x, int n, uint[] z)
		{
		}

		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
		}

		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
		}

		public static void Twice(uint[] x, uint[] z)
		{
		}

		private static void AddPInvTo(uint[] z)
		{
		}

		private static void SubPInvFrom(uint[] z)
		{
		}
	}
}
