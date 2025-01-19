using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityGameModeOne : UIPanelSingle
	{
		private static int prevLayer;

		private static int selectLevelIndex;

		private static int selectNustrumIndex;

		public UIScrollView buffDescScrollView;

		public UILabel buffDescLabel;

		public ButtonEx buffDescOpenButton;

		public ButtonEx buffDescCloseButton;

		public GameObject buffDescContent;

		public UILabel activity1BuffNoteLabel;

		public UITexture bgTex;

		public UIPanelSingleContainer levels;

		public UILabel levelTitleLabel;

		public UILabel enemyPowerLabel;

		public UILabel currencyMultLabel;

		public UILabel needCurrencyLabel;

		public UILabel needCurrencyTitleLabel;

		public UILabel nustrumTitleLabel;

		public UIPanelSingleContainer nostrums;

		public UIPanelSingleContainer props;

		public UILabel currentLayerLabel;

		public UILabel cdTimeLabel;

		public UILabel multTipsLabel;

		public AGMO_LevelProgressIcon[] progressIcons;

		public ActivityMultModeSlider multModeSlider;

		public AGMO_LevelItemDetail levelItemDetail;

		public AGMO_NustrumItemDetail nustrumItemDetail;

		public LoadUIPanelSingle detailLoader;

		public LoadUIPanelSingle resetLoader;

		public ButtonEx resetButton;

		public ButtonEx nextLayerButton;

		public ButtonEx fightingButton;

		public ButtonEx detailButton;

		public ButtonEx storeButton;

		public int currentLayer;

		public bool canFight;

		public bool canReset;

		public bool canGetReward;

		public bool canGotoNextLayer;

		public long activitySerial;

		public long cd;

		public AGMO_LevelItem selectLevel;

		public AGMO_NustrumItem selectNustrum;

		public List<AGMO_PropItemData> propDataList;

		public List<AGMO_NustrumItemData> nostrumDataList;

		public List<AGMO_LevelItemData> levelDataList;

		public bool isDebug;

		private Rule1ActivityPlayMode playMode;

		private ActivityPlaySystemManagerRule1View activityPlaySystemManagerView;

		protected override void Awake()
		{
		}

		private void CloseBuffDesc()
		{
		}

		private void OpenBuffDesc()
		{
		}

		private void OnSliderChange(ActivityMultModeSlider slider)
		{
		}

		private void Update()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void ShowRewardPanel()
		{
		}

		public void GetRewardFinish()
		{
		}

		private int GetCurrentBattleCount(bool limitIndex = true)
		{
			return 0;
		}

		public override void UpdatePanel()
		{
		}

		private void OnLevelItemClick(AGMO_LevelItem item)
		{
		}

		private void OnLevelItemClick(AGMO_LevelItem item, bool isRefresh)
		{
		}

		private void OnNustrumItemClick(AGMO_NustrumItem item)
		{
		}

		private void OnNustrumItemClick(AGMO_NustrumItem item, bool isRefresh)
		{
		}

		private void FightingClick()
		{
		}

		private void NextLayerClick()
		{
		}

		private string CanFight()
		{
			return null;
		}

		public void GoToNextFloorRule1Finish()
		{
		}

		private void ResetClick()
		{
		}

		private string CheckCanReset(int layer)
		{
			return null;
		}

		private void ResetLayer(int layer)
		{
		}

		public void ResetFinish()
		{
		}

		private void DetailClick()
		{
		}
	}
}
