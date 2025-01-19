using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.View.UIFrame
{
	public class MailUIscene : UIScene
	{
		public override AssetsManager.AssetsType UnloadOnClose
		{
			get
			{
				return default(AssetsManager.AssetsType);
			}
		}

		public override void Show(UIDataBase mData = null)
		{
		}

		public override void InitConfig()
		{
		}
	}
}
