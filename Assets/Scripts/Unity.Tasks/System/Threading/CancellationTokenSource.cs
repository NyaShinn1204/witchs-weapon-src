namespace System.Threading
{
	public sealed class CancellationTokenSource
	{
		private object mutex;

		private Action actions;

		private bool isCancellationRequested;

		internal bool IsCancellationRequested
		{
			get
			{
				return false;
			}
		}

		public CancellationToken Token
		{
			get
			{
				return default(CancellationToken);
			}
		}

		public CancellationTokenSource(int millisecondsDelay)
		{
		}

		internal CancellationTokenRegistration Register(Action action)
		{
			return default(CancellationTokenRegistration);
		}

		internal void Unregister(Action action)
		{
		}

		public void Cancel()
		{
		}

		public void Cancel(bool throwOnFirstException)
		{
		}
	}
}
