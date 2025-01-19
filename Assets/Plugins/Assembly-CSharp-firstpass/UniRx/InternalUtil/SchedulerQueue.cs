namespace UniRx.InternalUtil
{
	public class SchedulerQueue
	{
		private readonly PriorityQueue<ScheduledItem> _queue;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public SchedulerQueue()
		{
		}

		public SchedulerQueue(int capacity)
		{
		}

		public void Enqueue(ScheduledItem scheduledItem)
		{
		}

		public bool Remove(ScheduledItem scheduledItem)
		{
			return false;
		}

		public ScheduledItem Dequeue()
		{
			return null;
		}

		public ScheduledItem Peek()
		{
			return null;
		}
	}
}
