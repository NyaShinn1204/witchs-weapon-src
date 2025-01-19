using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LeanCloud.Storage.Internal
{
	public sealed class Dispatcher
	{
		private readonly ReaderWriterLockSlim dispatchQueueLock;

		private readonly Queue<Action> dispatchQueue;

		public static Dispatcher Instance { get; private set; }

		public GameObject GameObject { get; set; }

		public IEnumerator DispatcherCoroutine { get; private set; }

		static Dispatcher()
		{
		}

		private Dispatcher()
		{
		}

		public void Post(Action action)
		{
		}

		private IEnumerator CreateDispatcherCoroutine()
		{
			return null;
		}
	}
}
