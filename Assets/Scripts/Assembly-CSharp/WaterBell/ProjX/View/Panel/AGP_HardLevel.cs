namespace WaterBell.ProjX.View.Panel
{
	public class AGP_HardLevel : UIPanelSingle
	{
		private const string generalBg = "UI/UIImage/ActivityPlayMode/Frame_Mine_Activity_BG";

		private const string maxLayerBg = "UI/UIImage/ActivityPlayMode/Frame_Mine_Activity_BG2";

		public UIPanelSingleContainer buffIconContainer;

		public UILabel layerLabel;

		public UILabel activity3NowFloorLabel;

		public ButtonEx beginGameButton;

		public UILabel enemyBuffLabel;

		public UILabel activity3EnemyBuffLabel;

		public ButtonEx enemyBuffButton;

		public UITexture box;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
