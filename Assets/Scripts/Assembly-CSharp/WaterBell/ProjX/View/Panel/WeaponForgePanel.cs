using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponForgePanel : UIPanelSingle
	{
		public static WeaponForgePanel current;

		public UI2DSprite weaponImage;

		public UIPanelSingleContainer forgeItemContainer;

		public UILabel nameLabel;

		public UISprite rareIcon;

		public GameObject forgeLevelUp;

		public GameObject forgeMax;

		public UIPanelSingleContainer propItemContainer;

		public WeaponButtonItem awakeButton_1;

		public WeaponButtonItem awakeButton_2;

		public WeaponButtonItem unawakeButton;

		public UIPanelSingleContainer awakeItemContainer;

		public UILabel tipsLabel;

		public GameObject awakeLevelUp;

		public GameObject awakeMax;

		public GameObject awakeState;

		public GameObject unawakenedState;

		public ButtonEx awakenButton;

		public ButtonEx closeButton;

		public ButtonEx bgCloseButton;

		public ButtonEx helpButton;

		public LoadUIPanelSingle awakeSuccLoader;

		public LoadUIPanelSingle forgeSuccLoader;

		public LoadUIPanelSingle helpLoader;

		private long weaponId;

		private string canPromoteWeaponSpell;

		private bool isAwakeMax;

		private List<WeaponItemData> awakeItemDataList;

		private List<PropItemData> propItemDataList;

		private WeaponAndSpellPromoteInfoView weaponAndSpellPromoteInfoView;

		private SingleServantWeaponView singleServantWeaponView;

		protected override void Awake()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void BindUFrame()
		{
		}

		private void WeaponForge()
		{
		}

		private void WeaponAwake()
		{
		}
	}
}
