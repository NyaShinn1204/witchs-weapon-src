using System;

namespace WaterBell.ProjX.View.Panel
{
	public class RuneItem : UIPanelSingle
	{
		public UILabel valueLabel;

		public UISprite lockIcon;

		public RuneIcon icon;

		private RuneItemData runeItemData;

		public Action<RuneItem> OnClickEvent;

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}
	}
}
