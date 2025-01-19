namespace BestHTTP.Extensions
{
	public sealed class CircularBuffer<T>
	{
		private T[] buffer;

		private int startIdx;

		private int endIdx;

		public int Capacity { get; private set; }

		public int Count { get; private set; }

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public CircularBuffer(int capacity)
		{
		}

		public void Add(T element)
		{
		}

		public void Clear()
		{
		}
	}
}
