using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class Jumper : DTNode
	{
		[SerializeField]
		private string _sourceNodeUID;

		private object _sourceNode;

		private string sourceNodeUID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private DTNode sourceNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

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
	}
}
