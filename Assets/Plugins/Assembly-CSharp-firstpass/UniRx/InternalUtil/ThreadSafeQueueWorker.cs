using System;

namespace UniRx.InternalUtil
{
	public class ThreadSafeQueueWorker
	{
		private const int InitialSize = 10;

		private object gate;

		private bool dequing;

		private int actionListCount;

		private Action[] actionList;

		private int waitingListCount;

		private Action[] waitingList;

		public void Enqueue(Action action)
		{
		}

		public void ExecuteAll(Action<Exception> unhandledExceptionCallback)
		{
		}
	}
}
