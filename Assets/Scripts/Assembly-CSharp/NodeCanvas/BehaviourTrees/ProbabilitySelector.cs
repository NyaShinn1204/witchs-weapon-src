using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class ProbabilitySelector : BTComposite
	{
		public List<BBParameter<float>> childWeights;

		public BBParameter<float> failChance;

		private float probability;

		private float currentProbability;

		private List<int> failedIndeces;

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

		public override void OnGraphStarted()
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		private float GetTotal()
		{
			return 0f;
		}
	}
}
