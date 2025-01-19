using System;

namespace WaterBell.ProjX.View.Panel
{
	public class CosplayButtonItem : UIPanelSingle
	{
		public UISprite[] slotsStates;

		public UISprite blackMask;

		public UISprite icon;

		private CosplayButtonItemData m_CosplayButtonItemData;

		public Action<CosplayButtonItem> OnClickEvent;

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}
	}
}
