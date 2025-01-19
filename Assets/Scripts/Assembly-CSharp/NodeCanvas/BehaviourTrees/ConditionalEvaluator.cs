using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask>, ITaskAssignable
	{
		public bool isDynamic;

		[SerializeField]
		private ConditionTask _condition;

		private bool accessed;

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

		protected override void OnReset()
		{
		}
	}
}
