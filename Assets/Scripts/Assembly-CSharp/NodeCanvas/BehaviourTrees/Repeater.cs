using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Repeater : BTDecorator
	{
		public enum RepeaterMode
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}

		public enum RepeatUntilStatus
		{
			Failure = 0,
			Success = 1
		}

		private bool isReset;

		public RepeaterMode repeaterMode;

		public RepeatUntilStatus repeatUntilStatus;

		public BBParameter<int> repeatTimes;

		private int currentIteration;

		private Entity en;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}
	}
}
