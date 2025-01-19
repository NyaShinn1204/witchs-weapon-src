using System.Collections.Generic;
using System.Diagnostics;

namespace UniRx
{
	public static class AotSafeExtensions
	{
		[DebuggerHidden]
		public static IEnumerable<T> AsSafeEnumerable<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static IObservable<Tuple<T>> WrapValueToClass<T>(this IObservable<T> source) where T : struct
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerable<Tuple<T>> WrapValueToClass<T>(this IEnumerable<T> source) where T : struct
		{
			return null;
		}
	}
}
