namespace WaterBell.ProjX.View.UIFrame
{
	public class StoryUIScene : UIScene
	{
		public override AssetsManager.AssetsType UnloadOnClose
		{
			get
			{
				return default(AssetsManager.AssetsType);
			}
		}

		public override void InitConfig()
		{
		}
	}
}
