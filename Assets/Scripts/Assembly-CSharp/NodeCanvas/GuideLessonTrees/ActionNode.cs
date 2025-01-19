using System.Collections;
using System.Diagnostics;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.GuideLessonTrees
{
	public class ActionNode : GLTNode, ITaskAssignable<ActionTask>, ITaskAssignable
	{
		[SerializeField]
		private ActionTask _action;

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

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		[DebuggerHidden]
		private IEnumerator UpdateAction(Component actionAgent)
		{
			return null;
		}

		private void OnActionEnd(bool success)
		{
		}

		protected override void OnReset()
		{
		}

		public override void OnGraphPaused()
		{
		}
	}
}
