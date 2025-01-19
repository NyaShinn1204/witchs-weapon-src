using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
	{
		[SerializeField]
		private ConditionTask _condition;

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

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public override bool requireActorSelection
		{
			get
			{
				return false;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}
	}
}
