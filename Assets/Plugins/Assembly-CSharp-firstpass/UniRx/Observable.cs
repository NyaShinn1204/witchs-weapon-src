using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace UniRx
{
	public static class Observable
	{
		private class AnonymousObservable<T> : IObservable<T>
		{
			private readonly Func<IObserver<T>, IDisposable> subscribe;

			public AnonymousObservable(Func<IObserver<T>, IDisposable> subscribe)
			{
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		private class ConnectableObservable<T> : IConnectableObservable<T>, IObservable<T>
		{
			private readonly IObservable<T> source;

			private readonly ISubject<T> subject;

			public ConnectableObservable(IObservable<T> source, ISubject<T> subject)
			{
			}

			public IDisposable Connect()
			{
				return null;
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		private static readonly TimeSpan InfiniteTimeSpan;

		private static readonly HashSet<Type> YieldInstructionTypes;

		private static IObservable<T> AddRef<T>(IObservable<T> xs, RefCountDisposable r)
		{
			return null;
		}

		public static IObservable<TSource> Scan<TSource>(this IObservable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			return null;
		}

		public static IObservable<TAccumulate> Scan<TSource, TAccumulate>(this IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return null;
		}

		public static IConnectableObservable<T> Multicast<T>(this IObservable<T> source, ISubject<T> subject)
		{
			return null;
		}

		public static IConnectableObservable<T> Publish<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IConnectableObservable<T> Publish<T>(this IObservable<T> source, T initialValue)
		{
			return null;
		}

		public static IConnectableObservable<T> PublishLast<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, IScheduler scheduler)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, int bufferSize)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, int bufferSize, IScheduler scheduler)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, TimeSpan window)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, TimeSpan window, IScheduler scheduler)
		{
			return null;
		}

		public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, int bufferSize, TimeSpan window, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> RefCount<T>(this IConnectableObservable<T> source)
		{
			return null;
		}

		public static T Wait<T>(this IObservable<T> source)
		{
			return default(T);
		}

		public static T Wait<T>(this IObservable<T> source, TimeSpan timeout)
		{
			return default(T);
		}

		private static T WaitCore<T>(IObservable<T> source, bool throwOnEmpty, TimeSpan timeout)
		{
			return default(T);
		}

		public static IObservable<TSource> Concat<TSource>(params IObservable<TSource>[] sources)
		{
			return null;
		}

		public static IObservable<TSource> Concat<TSource>(this IEnumerable<IObservable<TSource>> sources)
		{
			return null;
		}

		public static IObservable<TSource> Concat<TSource>(this IObservable<IObservable<TSource>> sources)
		{
			return null;
		}

		public static IObservable<TSource> Concat<TSource>(this IObservable<TSource> first, IObservable<TSource> second)
		{
			return null;
		}

		private static IObservable<T> ConcatCore<T>(IEnumerable<IObservable<T>> sources)
		{
			return null;
		}

		public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources)
		{
			return null;
		}

		public static IObservable<TSource> Merge<TSource>(params IObservable<TSource>[] sources)
		{
			return null;
		}

		public static IObservable<T> Merge<T>(this IObservable<IObservable<T>> sources)
		{
			return null;
		}

		public static IObservable<T> Merge<T>(this IObservable<IObservable<T>> sources, int maxConcurrent)
		{
			return null;
		}

		public static IObservable<TResult> Zip<TLeft, TRight, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector)
		{
			return null;
		}

		public static IObservable<IList<T>> Zip<T>(this IEnumerable<IObservable<T>> sources)
		{
			return null;
		}

		public static IObservable<IList<T>> Zip<T>(params IObservable<T>[] sources)
		{
			return null;
		}

		public static IObservable<TResult> CombineLatest<TLeft, TRight, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector)
		{
			return null;
		}

		public static IObservable<IList<T>> CombineLatest<T>(this IEnumerable<IObservable<T>> sources)
		{
			return null;
		}

		public static IObservable<IList<TSource>> CombineLatest<TSource>(params IObservable<TSource>[] sources)
		{
			return null;
		}

		public static IObservable<T> Switch<T>(this IObservable<IObservable<T>> sources)
		{
			return null;
		}

		public static IObservable<T[]> WhenAll<T>(params IObservable<T>[] sources)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, T value)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, params T[] values)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, IEnumerable<T> values)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, IScheduler scheduler, T value)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, IScheduler scheduler, params T[] values)
		{
			return null;
		}

		public static IObservable<T> StartWith<T>(this IObservable<T> source, IScheduler scheduler, IEnumerable<T> values)
		{
			return null;
		}

		public static IObservable<T> Synchronize<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Synchronize<T>(this IObservable<T> source, object gate)
		{
			return null;
		}

		public static IObservable<T> ObserveOn<T>(this IObservable<T> source, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> SubscribeOn<T>(this IObservable<T> source, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> DelaySubscription<T>(this IObservable<T> source, TimeSpan dueTime)
		{
			return null;
		}

		public static IObservable<T> DelaySubscription<T>(this IObservable<T> source, TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> DelaySubscription<T>(this IObservable<T> source, DateTimeOffset dueTime)
		{
			return null;
		}

		public static IObservable<T> DelaySubscription<T>(this IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> AsObservable<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> ToObservable<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static IObservable<T> ToObservable<T>(this IEnumerable<T> source, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<TResult> Cast<TSource, TResult>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TResult> Cast<TSource, TResult>(this IObservable<TSource> source, TResult witness)
		{
			return null;
		}

		public static IObservable<TResult> OfType<TSource, TResult>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TResult> OfType<TSource, TResult>(this IObservable<TSource> source, TResult witness)
		{
			return null;
		}

		public static IObservable<T> Create<T>(Func<IObserver<T>, IDisposable> subscribe)
		{
			return null;
		}

		public static IObservable<T> Empty<T>()
		{
			return null;
		}

		public static IObservable<T> Empty<T>(IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Empty<T>(T witness)
		{
			return null;
		}

		public static IObservable<T> Empty<T>(IScheduler scheduler, T witness)
		{
			return null;
		}

		public static IObservable<T> Never<T>()
		{
			return null;
		}

		public static IObservable<T> Never<T>(T witness)
		{
			return null;
		}

		public static IObservable<T> Return<T>(T value)
		{
			return null;
		}

		public static IObservable<T> Return<T>(T value, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Throw<T>(Exception error)
		{
			return null;
		}

		public static IObservable<T> Throw<T>(Exception error, T witness)
		{
			return null;
		}

		public static IObservable<T> Throw<T>(Exception error, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Throw<T>(Exception error, IScheduler scheduler, T witness)
		{
			return null;
		}

		public static IObservable<int> Range(int start, int count)
		{
			return null;
		}

		public static IObservable<int> Range(int start, int count, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Repeat<T>(T value)
		{
			return null;
		}

		public static IObservable<T> Repeat<T>(T value, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Repeat<T>(T value, int repeatCount)
		{
			return null;
		}

		public static IObservable<T> Repeat<T>(T value, int repeatCount, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Repeat<T>(this IObservable<T> source)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerable<IObservable<T>> RepeatInfinite<T>(IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Defer<T>(Func<IObservable<T>> observableFactory)
		{
			return null;
		}

		public static IObservable<T> Start<T>(Func<T> function)
		{
			return null;
		}

		public static IObservable<T> Start<T>(Func<T> function, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<Unit> Start(Action action)
		{
			return null;
		}

		public static IObservable<Unit> Start(Action action, IScheduler scheduler)
		{
			return null;
		}

		public static Func<IObservable<T>> ToAsync<T>(Func<T> function)
		{
			return null;
		}

		public static Func<IObservable<T>> ToAsync<T>(Func<T> function, IScheduler scheduler)
		{
			return null;
		}

		public static Func<IObservable<Unit>> ToAsync(Action action)
		{
			return null;
		}

		public static Func<IObservable<Unit>> ToAsync(Action action, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<TR> Select<T, TR>(this IObservable<T> source, Func<T, TR> selector)
		{
			return null;
		}

		public static IObservable<TR> Select<T, TR>(this IObservable<T> source, Func<T, int, TR> selector)
		{
			return null;
		}

		public static IObservable<T> Where<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> Where<T>(this IObservable<T> source, Func<T, int, bool> predicate)
		{
			return null;
		}

		public static IObservable<TR> SelectMany<T, TR>(this IObservable<T> source, IObservable<TR> other)
		{
			return null;
		}

		public static IObservable<TR> SelectMany<T, TR>(this IObservable<T> source, Func<T, IObservable<TR>> selector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, int, IObservable<TResult>> selector)
		{
			return null;
		}

		public static IObservable<TR> SelectMany<T, TC, TR>(this IObservable<T> source, Func<T, IObservable<TC>> collectionSelector, Func<T, TC, TR> resultSelector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source, Func<TSource, int, IObservable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector)
		{
			return null;
		}

		public static IObservable<T[]> ToArray<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Do<T>(this IObservable<T> source, IObserver<T> observer)
		{
			return null;
		}

		public static IObservable<T> Do<T>(this IObservable<T> source, Action<T> onNext)
		{
			return null;
		}

		public static IObservable<T> Do<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static IObservable<T> Do<T>(this IObservable<T> source, Action<T> onNext, Action onCompleted)
		{
			return null;
		}

		public static IObservable<T> Do<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted)
		{
			return null;
		}

		public static IObservable<Notification<T>> Materialize<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Dematerialize<T>(this IObservable<Notification<T>> source)
		{
			return null;
		}

		public static IObservable<T> DefaultIfEmpty<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> DefaultIfEmpty<T>(this IObservable<T> source, T defaultValue)
		{
			return null;
		}

		public static IObservable<TSource> Distinct<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TSource> Distinct<TSource>(this IObservable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IObservable<TSource> Distinct<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IObservable<TSource> Distinct<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IObservable<T> DistinctUntilChanged<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> DistinctUntilChanged<T>(this IObservable<T> source, IEqualityComparer<T> comparer)
		{
			return null;
		}

		public static IObservable<T> DistinctUntilChanged<T, TKey>(this IObservable<T> source, Func<T, TKey> keySelector)
		{
			return null;
		}

		public static IObservable<T> DistinctUntilChanged<T, TKey>(this IObservable<T> source, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IObservable<T> IgnoreElements<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Finally<T>(this IObservable<T> source, Action finallyAction)
		{
			return null;
		}

		public static IObservable<T> Catch<T, TException>(this IObservable<T> source, Func<TException, IObservable<T>> errorHandler) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> Catch<TSource>(this IEnumerable<IObservable<TSource>> sources)
		{
			return null;
		}

		public static IObservable<TSource> CatchIgnore<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TSource> CatchIgnore<TSource, TException>(this IObservable<TSource> source, Action<TException> errorAction) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> Retry<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TSource> Retry<TSource>(this IObservable<TSource> source, int retryCount)
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource, TException>(this IObservable<TSource> source, Action<TException> onError) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource, TException>(this IObservable<TSource> source, Action<TException> onError, TimeSpan delay) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource, TException>(this IObservable<TSource> source, Action<TException> onError, int retryCount) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource, TException>(this IObservable<TSource> source, Action<TException> onError, int retryCount, TimeSpan delay) where TException : Exception
		{
			return null;
		}

		public static IObservable<TSource> OnErrorRetry<TSource, TException>(this IObservable<TSource> source, Action<TException> onError, int retryCount, TimeSpan delay, IScheduler delayScheduler) where TException : Exception
		{
			return null;
		}

		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Func<EventHandler<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) where TEventArgs : EventArgs
		{
			return null;
		}

		public static IObservable<Unit> FromEvent<TDelegate>(Func<Action, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler)
		{
			return null;
		}

		public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler)
		{
			return null;
		}

		public static IObservable<Unit> FromEvent(Action<Action> addHandler, Action<Action> removeHandler)
		{
			return null;
		}

		public static IObservable<T> FromEvent<T>(Action<Action<T>> addHandler, Action<Action<T>> removeHandler)
		{
			return null;
		}

		public static IObservable<T> Take<T>(this IObservable<T> source, int count)
		{
			return null;
		}

		public static IObservable<T> TakeWhile<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> TakeWhile<T>(this IObservable<T> source, Func<T, int, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> TakeUntil<T, TOther>(this IObservable<T> source, IObservable<TOther> other)
		{
			return null;
		}

		public static IObservable<T> Skip<T>(this IObservable<T> source, int count)
		{
			return null;
		}

		public static IObservable<T> SkipWhile<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> SkipWhile<T>(this IObservable<T> source, Func<T, int, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> SkipUntil<T, TOther>(this IObservable<T> source, IObservable<TOther> other)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, int count)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, int count, int skip)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, TimeSpan timeSpan)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, TimeSpan timeSpan, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, TimeSpan timeSpan, TimeSpan timeShift)
		{
			return null;
		}

		public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, TimeSpan timeSpan, TimeSpan timeShift, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<IList<TSource>> Buffer<TSource, TWindowBoundary>(this IObservable<TSource> source, IObservable<TWindowBoundary> windowBoundaries)
		{
			return null;
		}

		public static IObservable<T> Last<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Last<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> LastOrDefault<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> LastOrDefault<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		private static IObservable<T> LastCore<T>(this IObservable<T> source, bool useDefault)
		{
			return null;
		}

		public static IObservable<T> First<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> First<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> FirstOrDefault<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> FirstOrDefault<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		private static IObservable<T> FirstCore<T>(this IObservable<T> source, bool useDefault)
		{
			return null;
		}

		public static IObservable<T> Single<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> Single<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		public static IObservable<T> SingleOrDefault<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> SingleOrDefault<T>(this IObservable<T> source, Func<T, bool> predicate)
		{
			return null;
		}

		private static IObservable<T> SingleCore<T>(this IObservable<T> source, bool useDefault)
		{
			return null;
		}

		public static IObservable<long> Interval(TimeSpan period)
		{
			return null;
		}

		public static IObservable<long> Interval(TimeSpan period, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<long> Timer(TimeSpan dueTime)
		{
			return null;
		}

		public static IObservable<long> Timer(DateTimeOffset dueTime)
		{
			return null;
		}

		public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period)
		{
			return null;
		}

		public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period)
		{
			return null;
		}

		public static IObservable<long> Timer(TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<long> Timer(DateTimeOffset dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period, IScheduler scheduler)
		{
			return null;
		}

		private static IObservable<long> TimerCore(TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		private static IObservable<long> TimerCore(DateTimeOffset dueTime, IScheduler scheduler)
		{
			return null;
		}

		private static IObservable<long> TimerCore(TimeSpan dueTime, TimeSpan period, IScheduler scheduler)
		{
			return null;
		}

		private static IObservable<long> TimerCore(DateTimeOffset dueTime, TimeSpan period, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<Timestamped<TSource>> Timestamp<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<Timestamped<TSource>> Timestamp<TSource>(this IObservable<TSource> source, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(this IObservable<TSource> source, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Delay<T>(this IObservable<T> source, TimeSpan dueTime)
		{
			return null;
		}

		public static IObservable<TSource> Delay<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Sample<T>(this IObservable<T> source, TimeSpan interval)
		{
			return null;
		}

		public static IObservable<T> Sample<T>(this IObservable<T> source, TimeSpan interval, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime)
		{
			return null;
		}

		public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Timeout<T>(this IObservable<T> source, TimeSpan dueTime)
		{
			return null;
		}

		public static IObservable<T> Timeout<T>(this IObservable<T> source, TimeSpan dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<T> Timeout<T>(this IObservable<T> source, DateTimeOffset dueTime)
		{
			return null;
		}

		public static IObservable<T> Timeout<T>(this IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler)
		{
			return null;
		}

		public static IObservable<Unit> FromCoroutine(Func<IEnumerator> coroutine, bool publishEveryYield = false)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator WrapEnumerator(IEnumerator enumerator, IObserver<Unit> observer, CancellationToken cancellationToken, bool publishEveryYield)
		{
			return null;
		}

		public static IObservable<T> FromCoroutineValue<T>(Func<IEnumerator> coroutine, bool nullAsNextUpdate = true)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator WrapEnumeratorYieldValue<T>(IEnumerator enumerator, IObserver<T> observer, CancellationToken cancellationToken, bool nullAsNextUpdate)
		{
			return null;
		}

		public static IObservable<T> FromCoroutine<T>(Func<IObserver<T>, IEnumerator> coroutine)
		{
			return null;
		}

		public static IObservable<T> FromCoroutine<T>(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine)
		{
			return null;
		}

		public static IObservable<Unit> SelectMany<T>(this IObservable<T> source, IEnumerator coroutine, bool publishEveryYield = false)
		{
			return null;
		}

		public static IObservable<Unit> SelectMany<T>(this IObservable<T> source, Func<T, IEnumerator> selector, bool publishEveryYield = false)
		{
			return null;
		}

		public static IObservable<Unit> ToObservable(this IEnumerator coroutine, bool publishEveryYield = false)
		{
			return null;
		}

		public static IObservable<long> EveryUpdate()
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator EveryUpdateCore(IObserver<long> observer, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IObservable<long> EveryFixedUpdate()
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator EveryFixedUpdateCore(IObserver<long> observer, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IObservable<long> EveryEndOfFrame()
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator EveryEndOfFrameCore(IObserver<long> observer, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IObservable<T> DelayFrame<T>(this IObservable<T> source, int frameCount)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator DelayFrameCore(Action onNext, int frameCount, ICancelable cancel)
		{
			return null;
		}

		public static IEnumerator ToAwaitableEnumerator<T>(this IObservable<T> source, CancellationToken cancel = null)
		{
			return null;
		}

		public static IEnumerator ToAwaitableEnumerator<T>(this IObservable<T> source, Action<T> onResult, CancellationToken cancel = null)
		{
			return null;
		}

		public static IEnumerator ToAwaitableEnumerator<T>(this IObservable<T> source, Action<Exception> onError, CancellationToken cancel = null)
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerator ToAwaitableEnumerator<T>(this IObservable<T> source, Action<T> onResult, Action<Exception> onError, CancellationToken cancel = null)
		{
			return null;
		}

		public static Coroutine StartAsCoroutine<T>(this IObservable<T> source, CancellationToken cancel = null)
		{
			return null;
		}

		public static Coroutine StartAsCoroutine<T>(this IObservable<T> source, Action<T> onResult, CancellationToken cancel = null)
		{
			return null;
		}

		public static Coroutine StartAsCoroutine<T>(this IObservable<T> source, Action<Exception> onError, CancellationToken cancel = null)
		{
			return null;
		}

		public static Coroutine StartAsCoroutine<T>(this IObservable<T> source, Action<T> onResult, Action<Exception> onError, CancellationToken cancel = null)
		{
			return null;
		}

		public static IObservable<T> ObserveOnMainThread<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<T> SubscribeOnMainThread<T>(this IObservable<T> source)
		{
			return null;
		}

		public static IObservable<bool> EveryApplicationPause()
		{
			return null;
		}

		public static IObservable<bool> EveryApplicationFocus()
		{
			return null;
		}

		public static IObservable<Unit> OnceApplicationQuit()
		{
			return null;
		}
	}
}
