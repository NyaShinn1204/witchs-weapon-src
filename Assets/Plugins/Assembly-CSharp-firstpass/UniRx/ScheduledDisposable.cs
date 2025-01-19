using System;

namespace UniRx
{
	public sealed class ScheduledDisposable : ICancelable, IDisposable
	{
		private readonly IScheduler scheduler;

		private IDisposable disposable;

		private int isDisposed;

		public IScheduler Scheduler
		{
			get
			{
				return null;
			}
		}

		public IDisposable Disposable
		{
			get
			{
				return null;
			}
		}

		public bool IsDisposed
		{
			get
			{
				return false;
			}
		}

		public ScheduledDisposable(IScheduler scheduler, IDisposable disposable)
		{
		}

		public void Dispose()
		{
		}

		private void DisposeInner()
		{
		}
	}
}
