using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
	{
		public bool dynamic;

		[SerializeField]
		private ConditionTask _condition;

		private int succeedIndex;

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		public override string name
		{
			get
			{
				return null;
			}
		}

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

		private ConditionTask condition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}
	}
}
