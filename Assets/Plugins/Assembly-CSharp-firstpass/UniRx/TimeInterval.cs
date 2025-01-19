using System;

namespace UniRx
{
	[Serializable]
	public class TimeInterval<T> : IEquatable<TimeInterval<T>>
	{
		private readonly TimeSpan _interval;

		private readonly T _value;

		public T Value
		{
			get
			{
				return default(T);
			}
		}

		public TimeSpan Interval
		{
			get
			{
				return default(TimeSpan);
			}
		}

		public TimeInterval(T value, TimeSpan interval)
		{
		}

		public bool Equals(TimeInterval<T> other)
		{
			return false;
		}

		public static bool operator ==(TimeInterval<T> first, TimeInterval<T> second)
		{
			return false;
		}

		public static bool operator !=(TimeInterval<T> first, TimeInterval<T> second)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
