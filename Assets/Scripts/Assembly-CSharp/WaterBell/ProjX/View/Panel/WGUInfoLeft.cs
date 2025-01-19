using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class WGUInfoLeft : UIPanelSingle
	{
		public UISprite rankIcon;

		public UISprite rankNameIcon;

		public UILabel fightingValue;

		public List<UIImageNGUI> starImageList;

		public UILabel rankLevelLabel;

		private long servantId;

		private int star;

		private int rank;

		private int svcs;

		private void OnPress(bool isPress)
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
