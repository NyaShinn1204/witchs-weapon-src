using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SDGP_Item : UIPanelSingle
	{
		public UISprite icon;

		public UILabel nameLabel;

		public UILabel wayLabel;

		public UISprite wayIcon;

		public UISprite thumb;

		public GameObject lockIcon;

		private ButtonEx button;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
