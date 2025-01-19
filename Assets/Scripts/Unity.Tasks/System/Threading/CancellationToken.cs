namespace System.Threading
{
	public struct CancellationToken
	{
		private CancellationTokenSource source;

		public static CancellationToken None
		{
			get
			{
				return default(CancellationToken);
			}
		}

		public bool IsCancellationRequested
		{
			get
			{
				return false;
			}
		}

		internal CancellationToken(CancellationTokenSource source)
		{
			this.source = null;
		}

		public CancellationTokenRegistration Register(Action callback)
		{
			return default(CancellationTokenRegistration);
		}

		public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext)
		{
			return default(CancellationTokenRegistration);
		}

		public void ThrowIfCancellationRequested()
		{
		}
	}
}
