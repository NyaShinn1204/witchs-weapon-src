using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class Switch : BTComposite
	{
		public enum CaseSelectionMode
		{
			IndexBased = 0,
			EnumBased = 1
		}

		public enum OutOfRangeMode
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}

		[BlackboardOnly]
		public BBObjectParameter enumCase;

		public BBParameter<int> intCase;

		public CaseSelectionMode selectionMode;

		public OutOfRangeMode outOfRangeMode;

		private int current;

		private int runningIndex;

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
	}
}
