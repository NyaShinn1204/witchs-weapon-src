namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public struct fsOption<T>
	{
		private bool _hasValue;

		private T _value;

		public static fsOption<T> Empty;

		public bool HasValue
		{
			get
			{
				return false;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		public T Value
		{
			get
			{
				return default(T);
			}
		}

		public fsOption(T value)
		{
			_hasValue = false;
			_value = default(T);
		}
	}
	public static class fsOption
	{
		public static fsOption<T> Just<T>(T value)
		{
			return default(fsOption<T>);
		}
	}
}
