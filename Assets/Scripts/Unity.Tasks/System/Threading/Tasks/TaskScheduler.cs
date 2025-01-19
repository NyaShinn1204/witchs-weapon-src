namespace System.Threading.Tasks
{
	public class TaskScheduler
	{
		private static SynchronizationContext defaultContext;

		private SynchronizationContext context;

		public TaskScheduler(SynchronizationContext context)
		{
		}

		public void Post(Action action)
		{
		}

		public static TaskScheduler FromCurrentSynchronizationContext()
		{
			return null;
		}
	}
}
