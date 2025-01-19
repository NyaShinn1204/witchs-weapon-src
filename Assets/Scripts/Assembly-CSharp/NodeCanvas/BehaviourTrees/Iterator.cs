using System.Collections;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Iterator : BTDecorator
	{
		public enum TerminationConditions
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}

		[RequiredField]
		[BlackboardOnly]
		public BBParameter<IList> targetList;

		[BlackboardOnly]
		public BBObjectParameter current;

		[BlackboardOnly]
		public BBParameter<int> storeIndex;

		public BBParameter<int> maxIteration;

		public TerminationConditions terminationCondition;

		public bool resetIndex;

		private int currentIndex;

		private IList list
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
	}
}
