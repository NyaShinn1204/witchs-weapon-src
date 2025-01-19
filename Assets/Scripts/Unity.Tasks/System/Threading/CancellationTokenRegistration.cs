namespace System.Threading
{
	public struct CancellationTokenRegistration : IDisposable
	{
		private Action action;

		private CancellationTokenSource source;

		internal CancellationTokenRegistration(CancellationTokenSource source, Action action)
		{
			this.action = null;
			this.source = null;
		}

		public void Dispose()
		{
		}
	}
}
