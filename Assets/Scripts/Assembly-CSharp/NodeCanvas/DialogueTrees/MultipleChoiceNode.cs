using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class MultipleChoiceNode : DTNode, ISubTasksContainer
	{
		[Serializable]
		public class Choice
		{
			public bool isUnfolded;

			public Statement statement;

			public ConditionTask condition;

			public Choice()
			{
			}

			public Choice(Statement statement)
			{
			}
		}

		public float availableTime;

		public bool saySelection;

		[SerializeField]
		private List<Choice> availableChoices;

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

		public Task[] GetTasks()
		{
			return null;
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		private void OnOptionSelected(int index)
		{
		}
	}
}
