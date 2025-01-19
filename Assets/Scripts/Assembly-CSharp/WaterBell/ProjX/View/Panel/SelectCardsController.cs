using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class SelectCardsController : UIPanelBase
	{
		public SelectCardsData currentData;

		public List<int> selectMercenaryIndexs;

		public ButtonEx SelectedReturnBtn;

		public ButtonEx SelectingReturnBtn;

		public ButtonEx ContinueBtn;

		public ButtonEx DisContinueBtn;

		public ButtonEx FightingBtn;

		public ButtonEx DisFightingBtn;

		public ButtonEx ClothBtn;

		public ButtonEx OpenPropertyBtn;

		public ButtonEx OpenActivityAdvanceBtn;

		public Transform hpWidget;

		public Transform fightingWidget;

		public UILabel titleName;

		public UILabel hpText;

		public UISprite slider;

		public UILabel currTotalCSText;

		private int totalHp;

		private int limitHp;

		[HideInInspector]
		public int nowHp;

		public IPlayMode currmode;

		public static SelectCardsController current;

		private GameObject otherServantPrefab;

		public LoadUIPanelSingle clothLoader;

		public SelectProperty property;

		public SelectActivityAdvance advance;

		public SelectMercenarySvControl SelectMercenarySvPanel;

		public SelectWeaponControl weaponSelectView;

		public SelectingViewControl selectingView;

		public SelectExpeditionViewControl selectingExpeditonView;

		public SelectActivityViewControl selectingActivityView;

		public Transform selectedView;

		public Transform[] servantBoxs;

		public Transform[] weaponBoxs;

		public GameObject servantGrid;

		public GameObject otherServantGrid;

		public UIScrollView scroll;

		public UIToggle toggle;

		public UILabel ChallengeText;

		private GameObject ServantPrefab;

		private GameObject SelectMercenarySvPrefab;

		public UISprite heroFashion;

		private bool CanFighting
		{
			get
			{
				return false;
			}
		}

		public int ActivityMercenaryCount
		{
			get
			{
				return 0;
			}
		}

		protected override void Awake()
		{
		}

		protected override void AddConfigItem()
		{
		}

		private void ResetClothIcon()
		{
		}

		public void InitSelectedView()
		{
		}

		public void InitSelectingView()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void SetContinueBtnUI()
		{
		}

		public void FreshData()
		{
		}

		private void SetStoryLineView()
		{
		}

		private void SetDailyView()
		{
		}

		private void SetExpditionView()
		{
		}

		private bool IsRestrict()
		{
			return false;
		}

		private void SetChallenge()
		{
		}

		private void SetActivityView()
		{
		}

		private void SetWeapon()
		{
		}

		public void SelectServants()
		{
		}

		private void IsFighting()
		{
		}

		public void Fighting()
		{
		}

		private void ConfirmEvent()
		{
		}

		private void CannelEvent()
		{
		}

		public void ReSetHpAndFighting()
		{
		}

		public void ReSetHpUI()
		{
		}

		public void ReSetFightingUI()
		{
		}

		private void SetFightingBtnUI()
		{
		}

		private void DisFighting()
		{
		}

		private void AddEvent()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void ClickBack()
		{
		}

		private void HeroClothChange(long id)
		{
		}

		private void SetStoryServant()
		{
		}

		private void SetChallegeServant()
		{
		}

		public void SetExpeditionServant()
		{
		}

		public void SetActivityServant()
		{
		}
	}
}
