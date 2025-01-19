using System;

namespace UniRx
{
	public static class Disposable
	{
		private class EmptyDisposable : IDisposable
		{
			public static EmptyDisposable Singleton;

			private EmptyDisposable()
			{
			}

			public void Dispose()
			{
			}
		}

		private class AnonymousDisposable : IDisposable
		{
			private bool isDisposed;

			private readonly Action dispose;

			public AnonymousDisposable(Action dispose)
			{
			}

			public void Dispose()
			{
			}
		}

		public static readonly IDisposable Empty;

		public static IDisposable Create(Action disposeAction)
		{
			return null;
		}
	}
}
