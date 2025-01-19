using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
	{
		[SerializeField]
		private ConditionTask _condition;

		public Task task
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConditionTask condition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public override void PreExecute(BehaviourTree rootGraph)
		{
		}
	}
}
