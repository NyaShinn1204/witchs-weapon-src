using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WDP_SwitchSkin : UIPanelSingle
	{
		public ButtonEx useButton;

		public UITexture awakeImage;

		public UITexture unawakeImage;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public ButtonEx awakePoint;

		public ButtonEx unawakePoint;

		public GameObject awake;

		public GameObject unawake;

		public int currentSkinIndex;

		private SingleWeaponInfo weaponInfo;

		private SingleServantInfo servantInfo;

		private SwitchSkinView view;

		public UISprite weaponRareIcon;

		public UISprite weaponTypeIcon;

		public UILabel weaponNameLabel;

		public UtilAnchorAnim animAnchor;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void SwicthSkin()
		{
		}

		private void ShowSkin(int skinIndex)
		{
		}

		private void UseButtonClick()
		{
		}
	}
}
