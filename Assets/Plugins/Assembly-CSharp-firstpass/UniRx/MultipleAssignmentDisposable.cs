using System;

namespace UniRx
{
	public class MultipleAssignmentDisposable : IDisposable, ICancelable
	{
		private static readonly BooleanDisposable True;

		private object gate;

		private IDisposable current;

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
