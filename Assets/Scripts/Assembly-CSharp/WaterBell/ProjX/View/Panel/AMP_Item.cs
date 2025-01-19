using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AMP_Item : UIPanelSingle
	{
		private const int DISPLAY_CYCLE = 3;

		public UISprite info;

		public UILabel levelLabel;

		public GameObject star;

		public GameObject select;

		public GameObject lockIcon;

		public UISprite icon;

		public UIPanelSingleContainer loots;

		public UILabel indexLabel;

		public UILabel nameLabel;

		protected override void Start()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
