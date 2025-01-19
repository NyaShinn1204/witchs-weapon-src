namespace Facebook.Unity
{
	internal class ShareResult : ResultBase, IShareResult, IResult
	{
		public string PostId { get; private set; }

		internal static string PostIDKey
		{
			get
			{
				return null;
			}
		}

		internal ShareResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
