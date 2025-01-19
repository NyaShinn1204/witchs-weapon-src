using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Selector : BTComposite
	{
		public bool dynamic;

		public bool random;

		private int lastRunningNodeIndex;

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

		public override void OnChildDisconnected(int index)
		{
		}

		public override void OnGraphStarted()
		{
		}

		private List<Connection> Shuffle(List<Connection> list)
		{
			return null;
		}
	}
}
