using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class MultipleConditionNode : DTNode, ISubTasksContainer
	{
		[SerializeField]
		private List<ConditionTask> conditions;

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public Task[] GetTasks()
		{
			return null;
		}

		public override void OnChildConnected(int index)
		{
		}

		public override void OnChildDisconnected(int index)
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}
	}
}
