using System;

namespace ShaderWeaver
{
	[Serializable]
	public class SWLayerMask
	{
		public int mask;

		protected bool Has(int digit)
		{
			return false;
		}

		protected int Get(int digit)
		{
			return 0;
		}

		protected void Set(int digit, bool on)
		{
		}

		protected void Remove(int digit)
		{
		}
	}
}
