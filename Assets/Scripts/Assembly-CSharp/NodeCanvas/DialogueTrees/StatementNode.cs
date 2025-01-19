using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class StatementNode : DTNode
	{
		[SerializeField]
		private Statement statement;

		public override bool requireActorSelection
		{
			get
			{
				return false;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		private void OnStatementFinish()
		{
		}
	}
}
