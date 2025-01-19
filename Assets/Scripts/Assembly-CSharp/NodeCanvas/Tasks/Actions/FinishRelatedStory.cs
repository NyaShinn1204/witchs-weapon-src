using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class FinishRelatedStory : GuideTask
	{
		private bool isFinish;

		private bool isUnlockStory;

		private bool isUnlockStoryGroup;

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

		private void OnSuccFinish()
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
