using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	public class Progress<T> : IProgress<T> where T : EventArgs
	{
		private SynchronizationContext synchronizationContext;

		private SendOrPostCallback synchronizationCallback;

		private Action<T> eventHandler;

		[CompilerGenerated]
		private EventHandler<T> ProgressChanged;

		void IProgress<T>.Report(T value)
		{
		}

		protected virtual void OnReport(T value)
		{
		}

		private void NotifyDelegates(object newValue)
		{
		}
	}
}
