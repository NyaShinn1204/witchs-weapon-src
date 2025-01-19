using System;

namespace WaterBell.ProjX.View.Panel
{
	public class SlotsItem : UIPanelSingle
	{
		public RuneIcon runeIcon;

		public UISprite lightIcon;

		private SlotsItemData m_SlotsItemData;

		public Action<SlotsItem> OnClickEvent;

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}
	}
}
