using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.GuideLessonTrees
{
	public class ContinuePlanNode : GLTNode
	{
		public List<string> playPlanList;

		public int currListLen;

		private bool isInvalid;

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}
	}
}
