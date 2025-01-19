using System;

namespace WaterBell.ProjX.View.Panel
{
	public class RuneIcon : UIPanelSingle
	{
		private enum RuneColors
		{
			Rune_Red = 0,
			Rune_Orange = 1,
			Rune_Yellow = 2,
			Rune_Green = 3,
			Rune_Cyan = 4,
			Rune_Blue = 5,
			Rune_Warm = 6,
			Rune_Cool = 7,
			Rune_General = 8
		}

		public UISprite icon;

		public UISprite color;

		private RuneIconData m_RuneIconData;

		public Action<RuneIcon> OnClickEvent;

		public override void UpdatePanel()
		{
		}

		private void OnClick()
		{
		}
	}
}
