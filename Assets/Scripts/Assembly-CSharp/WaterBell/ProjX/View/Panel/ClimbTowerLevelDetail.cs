using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ClimbTowerLevelDetail : UIPanelSingle
	{
		public static ClimbTowerLevelDetail current;

		public UIPanelSingleContainer levelContainer;

		public CTLD_WeaponButton weaponButton;

		public UILabel countLabel;

		public LoadUIPanelSingle selectWeaponPanelLoader;

		public ButtonEx openSelectPanelButton;

		public GameObject selectTips;

		public GameObject cannotSelect;

		public GameObject select;

		public UILabel tipsLabel;

		public UILabel needGold;

		public ButtonEx helpButton;

		public TweenPosition m_TPMoveObj;

		public UISprite m_SpriteState;

		private float speed;

		private List<CTLD_LevelButtonData> levelDataList;

		private long selectWeaponID;

		private WeaponDailyManagerView weaponDailyManagerView;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OpenHelpPanel()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SelectLevel(CTLD_LevelButtonData data)
		{
		}

		public string SelectWeapon(long weaponID)
		{
			return null;
		}

		private void OpenSelectWeaponPanel(long weaponID)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
