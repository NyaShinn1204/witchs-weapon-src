using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class FlipSelector : BTComposite
	{
		private int current;

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

		private void SendToBack(int i)
		{
		}

		protected override void OnReset()
		{
		}
	}
}
