using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponDevPanel : UIPanelSingle
	{
		public static WeaponDevPanel current;

		protected const string SKILL = "Skill";

		protected const string COMPOUND = "Compound";

		protected const string SWITCH_SKIN = "SwitchSkin";

		protected const string AWAKE = "Awake";

		protected const string MAIN = "Main";

		private readonly List<string> devStepList;

		public UIMixWidget image;

		public UISprite rareIcon;

		public UISprite weaponTypeIcon;

		public UILabel nameLabel;

		public UISprite lockIcon;

		public WDP_SvIcon svIcon;

		public WeaponButtonItem2 weaponItem;

		private List<WeaponButtonItem2> weaponList;

		public UIGrid weaponGrid;

		public ButtonEx switchWatchmenButton;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public ButtonEx compoundButton;

		public ButtonEx switchSkinButton;

		public ButtonEx awakeButton;

		public ButtonEx mainButton;

		public GameObject awakeRedPoint;

		public LoadUIPanelSingle compoundLoader;

		public LoadUIPanelSingle switchSkinLoader;

		public LoadUIPanelSingle awakeLoader;

		public GameObject awakeEffect;

		protected SingleWeaponInfo weaponInfo;

		protected SingleServantInfo servantInfo;

		protected string childName;

		protected UIPanelSingle currentChild;

		protected CurrentServantWeaponInfoView weaponView;

		protected SingleServantWeaponView view;

		protected RenderTexture imageRT;

		public WDP_SkillIcon skillButton1;

		public WDP_SkillIcon skillButton2;

		public UIWeaponSpellTipController spellTip;

		public PropertyWeaponController property;

		public UtilAnchorAnim anchorAnim;

		public ButtonEx buttonToMain;

		public UILabel svLevelLabel;

		public UISprite svExpBar;

		public LoadUIPanelSingle levelUpPanelLoad;

		public UILabel weaponLevelLabel;

		public UISprite weaponExpBar;

		public LoadUIPanelSingle intensifyLoader;

		public ButtonEx openLevelUpPanelButton;

		public ButtonEx intensifyButton;

		protected override void Awake()
		{
		}

		private void OpenIntensifyPanel()
		{
		}

		public void OpenLevelUpPanel()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		protected override void BindData()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void UpdateWeaponSpell()
		{
		}

		private void ShowSpellTip(int sIndex)
		{
		}

		protected virtual void GotoServantDevPanel()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void UpdateButtonState()
		{
		}

		protected virtual void SwitchWeapon(long weaponID)
		{
		}

		private void OpenChild(ButtonEx button)
		{
		}

		public void OpenChild(string child)
		{
		}

		protected virtual void Next()
		{
		}

		protected virtual void Prev()
		{
		}
	}
}
