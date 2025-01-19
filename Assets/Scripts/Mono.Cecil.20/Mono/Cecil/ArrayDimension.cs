namespace Mono.Cecil
{
	public struct ArrayDimension
	{
		private int? lower_bound;

		private int? upper_bound;

		public bool IsSized
		{
			get
			{
				return false;
			}
		}

		public ArrayDimension(int? lowerBound, int? upperBound)
		{
			lower_bound = null;
			upper_bound = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
