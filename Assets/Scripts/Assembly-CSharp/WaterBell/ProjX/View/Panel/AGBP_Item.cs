using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGBP_Item : UIPanelSingle
	{
		public UILabel nameLabel;

		public UILabel levelLabel;

		public UILabel currencyLabel;

		public UISprite headIcon;

		public UISprite headBoxIcon;

		public UILabel indexLabel;

		public UISprite indexIcon;

		public UILabel titleLabel;

		public ButtonEx detailButton;

		public GameObject battleFormationButton;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetBattleFormationActive(bool value)
		{
		}
	}
}
