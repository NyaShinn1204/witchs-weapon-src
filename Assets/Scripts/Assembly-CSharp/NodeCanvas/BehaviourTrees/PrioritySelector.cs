using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class PrioritySelector : BTComposite
	{
		public List<BBParameter<float>> priorities;

		private List<Connection> orderedConnections;

		private int current;

		public override string name
		{
			get
			{
				return null;
			}
		}

		public override void OnChildConnected(int index)
		{
		}

		public override void OnChildDisconnected(int index)
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}
	}
}
