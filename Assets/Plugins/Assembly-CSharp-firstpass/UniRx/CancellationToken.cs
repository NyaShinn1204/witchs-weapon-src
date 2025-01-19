namespace UniRx
{
	public class CancellationToken
	{
		private readonly ICancelable source;

		public static CancellationToken Empty;

		public bool IsCancellationRequested
		{
			get
			{
				return false;
			}
		}

		public CancellationToken(ICancelable source)
		{
		}

		public void ThrowIfCancellationRequested()
		{
		}
	}
}
