using System.Collections.Generic;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class SubDialogueTree : DTNode, IGraphAssignable, ISubParametersContainer
	{
		[SerializeField]
		private BBParameter<DialogueTree> _subTree;

		[SerializeField]
		private Dictionary<string, string> actorParametersMap;

		[SerializeField]
		private Dictionary<string, BBObjectParameter> variablesMap;

		private Dictionary<DialogueTree, DialogueTree> instances;

		Graph IGraphAssignable.nestedGraph
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

		public DialogueTree subTree
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Graph[] IGraphAssignable.GetInstances()
		{
			return null;
		}

		BBParameter[] ISubParametersContainer.GetIncludeParseParameters()
		{
			return null;
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		private void SetActorParametersMapping()
		{
		}

		private void SetVariablesMapping()
		{
		}

		private void OnSubDialogueFinish(bool success)
		{
		}

		public override void OnGraphStoped()
		{
		}

		public override void OnGraphPaused()
		{
		}

		private bool IsInstance(DialogueTree dt)
		{
			return false;
		}

		private void CheckInstance()
		{
		}
	}
}
