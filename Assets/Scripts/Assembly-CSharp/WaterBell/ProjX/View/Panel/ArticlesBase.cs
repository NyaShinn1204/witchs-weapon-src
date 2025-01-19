using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ArticlesBase : UIPanelSingle
	{
		[Space]
		public UISprite bg;

		public UISprite icon;

		public UILabel count;

		public override void UpdatePanel()
		{
		}

		protected virtual void OnPress(bool isPress)
		{
		}
	}
}
