using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	public class StartDialogueTree : ActionTask
	{
		[RequiredField]
		public BBParameter<DialogueTreeController> dialogueTreeController;

		public bool waitActionFinish;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
