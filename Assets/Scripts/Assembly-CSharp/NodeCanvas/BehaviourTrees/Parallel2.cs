using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Parallel2 : BTComposite
	{
		public enum ParallelPolicy
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}

		public ParallelPolicy policy;

		public bool dynamic;

		private readonly List<Connection> finishedConnections;

		public override string name
		{
			get
			{
				return null;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		private void ResetRunning()
		{
		}
	}
}
