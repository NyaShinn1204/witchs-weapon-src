using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public abstract class DTNode : Node
	{
		[SerializeField]
		private string _actorName;

		[SerializeField]
		private string _actorParameterID;

		public override string name
		{
			get
			{
				return null;
			}
		}

		public virtual bool requireActorSelection
		{
			get
			{
				return false;
			}
		}

		public override int maxInConnections
		{
			get
			{
				return 0;
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public sealed override Type outConnectionType
		{
			get
			{
				return null;
			}
		}

		public sealed override bool allowAsPrime
		{
			get
			{
				return false;
			}
		}

		public sealed override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		protected DialogueTree DLGTree
		{
			get
			{
				return null;
			}
		}

		protected string actorName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected IDialogueActor finalActor
		{
			get
			{
				return null;
			}
		}
	}
}
