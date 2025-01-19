using NodeCanvas.Framework;
using WaterBell.ProjX.Guide;

namespace NodeCanvas.Tasks.Actions
{
	public class EndLesson : GuideTask
	{
		public GuideLessonExecutor.ExtraAction actionType;

		public string uiEventType;

		public long instanceID;

		public string settingStr;

		public int back2UISceneID;

		public int recID;

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

		protected override void OnUpdate()
		{
		}
	}
}
