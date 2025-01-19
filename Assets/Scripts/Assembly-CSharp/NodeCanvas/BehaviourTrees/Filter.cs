using System.Collections;
using System.Diagnostics;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Filter : BTDecorator
	{
		public enum FilterMode
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}

		public enum Policy
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}

		public FilterMode filterMode;

		public BBParameter<int> maxCount;

		public BBParameter<float> coolDownTime;

		public bool inactiveWhenLimited;

		public Policy policy;

		private int executedCount;

		private float currentTime;

		public override void OnGraphStarted()
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[DebuggerHidden]
		private IEnumerator Cooldown()
		{
			return null;
		}
	}
}
