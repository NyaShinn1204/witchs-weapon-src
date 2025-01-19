using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class RoleIconItem : UIPanelSingle
	{
		private const string TYPE_ICON_ENEMY_BOSS = "Enemy_Icon_Leader";

		private const string TYPE_ICON_ENEMY_ELITE = "Enemy_Icon_Elite";

		private const string TYPE_ICON_ALLIES_BOSS = "Friendly_Icon_Leader";

		private const string BG_ENEMY = "Enemy_Head_Frame_BG";

		private const string BG_ALLIES = "Friendly_Head_Frame_BG";

		private const string FREME_ELITE = "Enemy_Head_Frame_Elite";

		private const string FREME_NORMAL = "Enemy_Head_Frame_Normal";

		private const string FREAM_BOSS = "Enemy_Head_Frame_Boss";

		[Space]
		public UISprite quality;

		public UISprite photo;

		public UISprite typeIcon;

		public UILabel levelLabel;

		public GameObject bg;

		public RoleIconItemData roleData;

		public UISprite mobStage;

		public override void UpdatePanel()
		{
		}

		public void SetBgState(bool isActive)
		{
		}

		private void OnPress(bool isPress)
		{
		}
	}
}
