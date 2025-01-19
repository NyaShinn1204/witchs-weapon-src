using System;

namespace UniRx
{
	public class SingleAssignmentDisposable : IDisposable, ICancelable
	{
		private readonly object gate;

		private IDisposable current;

		private bool disposed;

		public bool IsDisposed
		{
			get
			{
				return false;
			}
		}

		public IDisposable Disposable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}
	}
}
