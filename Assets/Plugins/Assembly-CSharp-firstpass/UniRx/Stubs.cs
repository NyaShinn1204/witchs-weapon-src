using System;

namespace UniRx
{
	internal static class Stubs
	{
		public static readonly Action Nop;

		public static readonly Action<Exception> Throw;

		public static void Ignore<T>(T t)
		{
		}

		public static IObservable<TSource> CatchIgnore<TSource>(Exception ex)
		{
			return null;
		}
	}
}
