namespace Facebook.Unity
{
	internal class PayResult : ResultBase, IPayResult, IResult
	{
		public long ErrorCode
		{
			get
			{
				return 0L;
			}
		}

		internal PayResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
