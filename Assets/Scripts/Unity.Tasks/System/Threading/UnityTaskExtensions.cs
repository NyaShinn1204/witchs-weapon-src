using System.Collections.Generic;
using UnityEngine;

namespace System.Threading
{
	public class UnityTaskExtensions : MonoBehaviour
	{
		private static UnityTaskExtensions instance;

		private static readonly object instanceLock;

		private Queue<Action> actionQueue;

		private object actionLock;

		internal static UnityTaskExtensions Instance
		{
			get
			{
				return null;
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnLoad()
		{
		}

		private void Update()
		{
		}

		public void Post(Action action)
		{
		}
	}
}
