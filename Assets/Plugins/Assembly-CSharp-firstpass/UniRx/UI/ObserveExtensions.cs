using System;
using System.Collections;
using System.Diagnostics;

namespace UniRx.UI
{
	public static class ObserveExtensions
	{
		public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator PublishValueChanged<TSource, TProperty>(TSource source, Func<TSource, TProperty> propertySelector, TProperty firstValue, IObserver<TProperty> observer, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
