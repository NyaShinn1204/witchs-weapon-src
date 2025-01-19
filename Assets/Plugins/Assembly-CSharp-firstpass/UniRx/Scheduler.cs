using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using UniRx.InternalUtil;

namespace UniRx
{
	public static class Scheduler
	{
		private class CurrentThreadScheduler : IScheduler
		{
			private static class Trampoline
			{
				public static void Run(SchedulerQueue queue)
				{
				}
			}

			[ThreadStatic]
			private static SchedulerQueue s_threadLocalQueue;

			[ThreadStatic]
			private static Stopwatch s_clock;

			private static TimeSpan Time
			{
				get
				{
					return default(TimeSpan);
				}
			}

			[EditorBrowsable]
			public static bool IsScheduleRequired
			{
				get
				{
					return false;
				}
			}

			public DateTimeOffset Now
			{
				get
				{
					return default(DateTimeOffset);
				}
			}

			private static SchedulerQueue GetQueue()
			{
				return null;
			}

			private static void SetQueue(SchedulerQueue newQueue)
			{
			}

			public IDisposable Schedule(Action action)
			{
				return null;
			}

			public IDisposable Schedule(TimeSpan dueTime, Action action)
			{
				return null;
			}
		}

		private class ImmediateScheduler : IScheduler
		{
			public DateTimeOffset Now
			{
				get
				{
					return default(DateTimeOffset);
				}
			}

			public IDisposable Schedule(Action action)
			{
				return null;
			}

			public IDisposable Schedule(TimeSpan dueTime, Action action)
			{
				return null;
			}
		}

		public static class DefaultSchedulers
		{
			private static IScheduler constantTime;

			private static IScheduler tailRecursion;

			private static IScheduler iteration;

			private static IScheduler timeBasedOperations;

			private static IScheduler asyncConversions;

			public static IScheduler ConstantTimeOperations
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static IScheduler TailRecursion
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static IScheduler Iteration
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static IScheduler TimeBasedOperations
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static IScheduler AsyncConversions
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static void SetDefaultForUnity()
			{
			}

			public static void SetDotNetCompatible()
			{
			}
		}

		private class ThreadPoolScheduler : IScheduler
		{
			private sealed class Timer : IDisposable
			{
				private static readonly HashSet<System.Threading.Timer> s_timers;

				private readonly SingleAssignmentDisposable _disposable;

				private Action _action;

				private System.Threading.Timer _timer;

				private bool _hasAdded;

				private bool _hasRemoved;

				public Timer(TimeSpan dueTime, Action action)
				{
				}

				private void Tick(object state)
				{
				}

				private void Unroot()
				{
				}

				public void Dispose()
				{
				}
			}

			public DateTimeOffset Now
			{
				get
				{
					return default(DateTimeOffset);
				}
			}

			public IDisposable Schedule(Action action)
			{
				return null;
			}

			public IDisposable Schedule(DateTimeOffset dueTime, Action action)
			{
				return null;
			}

			public IDisposable Schedule(TimeSpan dueTime, Action action)
			{
				return null;
			}
		}

		private class MainThreadScheduler : IScheduler
		{
			public DateTimeOffset Now
			{
				get
				{
					return default(DateTimeOffset);
				}
			}

			[DebuggerHidden]
			private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation)
			{
				return null;
			}

			public IDisposable Schedule(Action action)
			{
				return null;
			}

			public IDisposable Schedule(DateTimeOffset dueTime, Action action)
			{
				return null;
			}

			public IDisposable Schedule(TimeSpan dueTime, Action action)
			{
				return null;
			}
		}

		private class IgnoreTimeScaleMainThreadScheduler : IScheduler
		{
			public DateTimeOffset Now
			{
				get
				{
					return default(DateTimeOffset);
				}
			}

			[DebuggerHidden]
			private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation)
			{
				return null;
			}

			public IDisposable Schedule(Action action)
			{
				return null;
			}

			public IDisposable Schedule(DateTimeOffset dueTime, Action action)
			{
				return null;
			}

			public IDisposable Schedule(TimeSpan dueTime, Action action)
			{
				return null;
			}
		}

		public static readonly IScheduler CurrentThread;

		public static readonly IScheduler Immediate;

		public static readonly IScheduler ThreadPool;

		private static IScheduler mainThread;

		private static IScheduler mainThreadIgnoreTimeScale;

		public static bool IsCurrentThreadSchedulerScheduleRequired
		{
			get
			{
				return false;
			}
		}

		public static DateTimeOffset Now
		{
			get
			{
				return default(DateTimeOffset);
			}
		}

		public static IScheduler MainThread
		{
			get
			{
				return null;
			}
		}

		public static IScheduler MainThreadIgnoreTimeScale
		{
			get
			{
				return null;
			}
		}

		public static TimeSpan Normalize(TimeSpan timeSpan)
		{
			return default(TimeSpan);
		}

		public static IDisposable Schedule(this IScheduler scheduler, DateTimeOffset dueTime, Action action)
		{
			return null;
		}

		public static IDisposable Schedule(this IScheduler scheduler, Action<Action> action)
		{
			return null;
		}

		public static IDisposable Schedule(this IScheduler scheduler, TimeSpan dueTime, Action<Action<TimeSpan>> action)
		{
			return null;
		}

		public static IDisposable Schedule(this IScheduler scheduler, DateTimeOffset dueTime, Action<Action<DateTimeOffset>> action)
		{
			return null;
		}
	}
}
