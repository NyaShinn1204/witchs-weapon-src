using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Sequencer : BTComposite
	{
		public bool dynamic;

		public bool random;

		public bool showLog;

		private int lastRunningNodeIndex;

		private Entity entity;

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
