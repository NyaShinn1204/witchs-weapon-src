using System;
using System.Threading;

namespace Pathfinding
{
	public class ThreadControlQueue
	{
		public class QueueTerminationException : Exception
		{
		}

		private Path head;

		private Path tail;

		private object lockObj;

		private int numReceivers;

		private bool blocked;

		private int blockedReceivers;

		private bool starving;

		private bool terminate;

		private ManualResetEvent block;

		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		public bool IsTerminating
		{
			get
			{
				return false;
			}
		}

		public bool AllReceiversBlocked
		{
			get
			{
				return false;
			}
		}

		public ThreadControlQueue(int numReceivers)
		{
		}

		public void Block()
		{
		}

		public void Unblock()
		{
		}

		public void Lock()
		{
		}

		public void Unlock()
		{
		}

		public void PushFront(Path p)
		{
		}

		public void Push(Path p)
		{
		}

		private void Starving()
		{
		}

		public void TerminateReceivers()
		{
		}

		public Path Pop()
		{
			return null;
		}

		public void ReceiverTerminated()
		{
		}

		public Path PopNoBlock(bool blockedBefore)
		{
			return null;
		}
	}
}
