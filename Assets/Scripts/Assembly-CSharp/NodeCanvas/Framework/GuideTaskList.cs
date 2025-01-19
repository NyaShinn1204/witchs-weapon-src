using System.Collections.Generic;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework
{
	[DoNotList]
	public class GuideTaskList : GuideTask
	{
		public enum ActionsExecutionMode
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}

		public ActionsExecutionMode executionMode;

		public List<GuideTask> actions;

		private int currentActionIndex;

		private readonly List<int> finishedIndeces;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnStop()
		{
		}

		protected override void OnPause()
		{
		}

		public override void OnDrawGizmos()
		{
		}

		public override void OnDrawGizmosSelected()
		{
		}

		public void AddAction(GuideTask action)
		{
		}
	}
}
