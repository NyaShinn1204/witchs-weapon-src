using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class WGUMain : UIPanelSingle
	{
		public static WGUMain current;

		public LoadUIPanelSingle skillLoad;

		public LoadUIPanelSingle weaponLoad;

		public LoadUIPanelSingle propertyLoad;

		public LoadUIPanelSingle starLoad;

		public LoadUIPanelSingle favorLoad;

		public LoadUIPanelSingle fashionLoad;

		private List<LoadUIPanelSingle> partLoadList;

		public WeaponButtonItem2 weaponItem;

		private List<WeaponButtonItem2> weaponList;

		public UIGrid weaponGrid;

		public ButtonEx nextButton;

		public ButtonEx prevButton;

		public ButtonEx openLevelUpPanelButton;

		public ButtonEx skillButton;

		public ButtonEx propertyButton;

		public ButtonEx starButton;

		public ButtonEx favorButton;

		public ButtonEx fashionButton;

		public ButtonEx pohtoButton;

		public PropertyServantView propertyView;

		public ButtonEx CVButton;

		public GameObject starPoint;

		public GameObject favorPoint;

		public GameObject favorImagePoint;

		public UILabel nameLabel;

		public UILabel svLevelLabel;

		public UISprite svExpBar;

		public UILabel atkLabel;

		public Transform starContent;

		public WGUBgContainer bgContainer;

		public ServantImagePanel servantImagePanel;

		public LoadUIPanelSingle levelUpPanelLoad;

		public ButtonEx intensifyButton;

		public UILabel weaponLevelLabel;

		public UISprite weaponExpBar;

		public LoadUIPanelSingle intensifyLoader;

		public GameObject spell1;

		public GameObject spell2;

		public UIWitchSpellTipController spellTip;

		public UtilAnchorAnim anchorAnim;

		public ButtonEx buttonToMain;

		[HideInInspector]
		public ServantDevelopMainInfoView servantDevelopMainInfoView;

		[HideInInspector]
		public UserInfoForSvDevelopView userInfoForSvDevelopView;

		private CurrentServantWeaponInfoView currentServantWeaponInfoView;

		private string currentPart;

		private ButtonEx[] tagButtons;

		[SerializeField]
		private SingleWeaponInfo weaponInfo;

		[SerializeField]
		private SingleServantInfo servantInfo;

		[NonSerialized]
		public ServantDevelopUIData servantDevelopUIData;

		public UIWitchCVController CVController;

		public GameObject favorView;

		private Spell Spell1Data
		{
			get
			{
				return null;
			}
		}

		private Spell Spell2Data
		{
			get
			{
				return null;
			}
		}

		protected override void Awake()
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

		private void OpenIntensifyPanel()
		{
		}

		protected override void AddConfigItem()
		{
		}

		private void OnTagClick(GameObject button, UIDataBase mData = null)
		{
		}

		private void OpenWeaponPanel(long weaponID)
		{
		}

		public void Prev()
		{
		}

		public void Next()
		{
		}

		private void StopCV()
		{
		}

		public void OpenChildPanel(string childName, UIDataBase mData = null)
		{
		}

		public void OpenLevelUpPanel()
		{
		}

		public override void UpdatePanel()
		{
		}

		private bool SpellIsLock(Spell sSpell)
		{
			return false;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
