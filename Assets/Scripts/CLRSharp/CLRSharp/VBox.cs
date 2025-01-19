namespace CLRSharp
{
	public class VBox
	{
		public int refcount;

		public NumberOnStack typeStack;

		public NumberType type;

		public int v32;

		public long v64;

		public double vDF;

		public VBox(NumberOnStack typeStack, NumberType thistype)
		{
		}

		public VBox Clone()
		{
			return null;
		}

		public object BoxDefine()
		{
			return null;
		}

		public void And(VBox right)
		{
		}

		public void Or(VBox right)
		{
		}

		public void Xor(VBox right)
		{
		}

		public void Not()
		{
		}

		public void Add(VBox right)
		{
		}

		public void Sub(VBox right)
		{
		}

		public void Mul(VBox right)
		{
		}

		public void Div(VBox right)
		{
		}

		public void Neg()
		{
		}

		public void Mod(VBox right)
		{
		}

		public void SetDirect(object value)
		{
		}

		public void Set(VBox value)
		{
		}

		public bool logic_eq(VBox right)
		{
			return false;
		}

		public bool logic_ne_Un(VBox right)
		{
			return false;
		}

		public bool logic_ge(VBox right)
		{
			return false;
		}

		public bool logic_ge_Un(VBox right)
		{
			return false;
		}

		public bool logic_le(VBox right)
		{
			return false;
		}

		public bool logic_le_Un(VBox right)
		{
			return false;
		}

		public bool logic_gt(VBox right)
		{
			return false;
		}

		public bool logic_gt_Un(VBox right)
		{
			return false;
		}

		public bool logic_lt(VBox right)
		{
			return false;
		}

		public bool logic_lt_Un(VBox right)
		{
			return false;
		}

		public bool ToBool()
		{
			return false;
		}

		public int ToInt()
		{
			return 0;
		}

		public uint ToUInt()
		{
			return 0u;
		}

		public long ToInt64()
		{
			return 0L;
		}

		public float ToFloat()
		{
			return 0f;
		}

		public double ToDouble()
		{
			return 0.0;
		}
	}
}
