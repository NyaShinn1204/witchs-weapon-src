namespace WaterBell.ProjX.View.Panel
{
	public class QuestUIData : UIDataBase
	{
		public const int SHOP_SCENE_ARG_DEFRAULT = 0;

		public const int SHOP_SCENE_ARG_TO_DIAMOND_SHOP_SET = 1;

		public const int SHOP_SCENE_ARG_TO_RECHARGE_SHOP_SET = 2;

		public const int SHOP_SCENE_ARG_TO_EXPEDITION_SHOP_SET = 3;

		public TaskMode currentTaskMode;

		public QuestUIData(TaskMode _mode = TaskMode.DefaultTask)
		{
		}
	}
}
