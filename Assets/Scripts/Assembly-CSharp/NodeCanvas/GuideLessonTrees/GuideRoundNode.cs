using System.Collections;
using System.Diagnostics;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.GuideLessonTrees
{
	public class GuideRoundNode : GLTNode, ISubTasksContainer, ITaskAssignable<GuideRound>, ITaskAssignable
	{
		[SerializeField]
		private GuideRound _roundInfo;

		private Coroutine roundUpdator;

		public GuideRound roundInfo
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

		public Task[] GetTasks()
		{
			return null;
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		public GuideRoundNode Jump2Next()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator UpdateGuideRound(Component agent)
		{
			return null;
		}

		public void RoundClear()
		{
		}

		private void OnActionEnd(bool success)
		{
		}

		private void OnStatementFinish()
		{
		}

		public override void OnValidate(Graph assignedGraph)
		{
		}
	}
}
