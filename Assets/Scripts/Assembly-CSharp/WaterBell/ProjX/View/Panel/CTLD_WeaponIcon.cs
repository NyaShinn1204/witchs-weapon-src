using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CTLD_WeaponIcon : UIPanelSingle
	{
		public UILabel nameLabel;

		public CTLD_WeaponButton weapon;

		public CTLD_WeaponButton weapon2;

		public CTLD_WeaponButton weapon3;

		public CTLD_WeaponButton weapon4;

		public Transform stars;

		public UISprite servant_rank_icon;

		public UILabel servant_rank;

		public UILabel levelLabel;

		public UITexture image;

		public GameObject selectBox;

		protected CTLD_WeaponButton[] weaponButtons;

		protected override void Awake()
		{
		}

		private void OnWeaponClick(long id)
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetSelectState(long weaponID)
		{
		}

		private void UpdateServantRank(int _rank)
		{
		}
	}
}
