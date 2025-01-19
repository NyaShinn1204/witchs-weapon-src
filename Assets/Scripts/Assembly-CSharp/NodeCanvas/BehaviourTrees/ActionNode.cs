using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class ActionNode : BTNode, ITaskAssignable<ActionTask>, ITaskAssignable
	{
		[SerializeField]
		private ActionTask _action;

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

		public ActionTask action
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

		protected override void OnReset()
		{
		}

		public override void OnGraphPaused()
		{
		}

		public override void PreExecute(BehaviourTree rootGraph)
		{
		}

		public override void ResetProtectingParams()
		{
		}
	}
}
