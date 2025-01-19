using System;
using System.Collections.Generic;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityGameModeFourPanel : UIPanelSingle
	{
		private static int prevFightingLayer;

		public UIPanelSingleContainer clearLevelAward;

		public UIPanelSingleContainer towerKind;

		public UIContainerWithSlider levels;

		public UILabel levelNameLabel;

		public UILabel levelDescLabel;

		public UILabel towerKindNameLabel;

		public UILabel towerDescLabel;

		public UILabel lootDescLabel;

		public LoadUIPanelSingle buffDetailLoader;

		public LoadUIPanelSingle awardLoader;

		public LoadUIPanelSingle confirmLoader;

		public UILabel awardDescLabel;

		public UITexture towerTypeTex;

		public UITexture bgTex;

		public UILabel intelligenceNameLabel;

		public UILabel intelligenceValueLabel;

		public UILabel resetValueLabel;

		public UILabel resetConsumeLabel;

		public UILabel resetLabel;

		public ButtonEx resetButton;

		public ButtonEx buffButton;

		public ButtonEx giftButton;

		public ButtonEx helpButton;

		public int currentTowerType;

		public float currentTowerAwardRate;

		public int currentLayer;

		public int maxLayer;

		public int passMaxLayer;

		public int minLayer;

		public int needVitWhenReset;

		public int lootModulus;

		public int extraLootLayer;

		public int extraLootType;

		public int serial;

		public int resetNeedActVit;

		public int layerProgress;

		public List<long> levelIdList;

		public List<LotteryLootData> buffDataList;

		public float buffValue;

		private AGMF_Award selectAward;

		public bool isDebug;

		private Rule4ActivityPlayMode playMode;

		private ActivityPlaySystemManagerRule4View activityPlaySystemManagerRule4View;

		protected override void Awake()
		{
		}

		private void OpenConfirmPanel(int mode)
		{
		}

		private void Update()
		{
		}

		private void OpenHelpPanel()
		{
		}

		private void OpenBuffPanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void CenterCurrentLayer()
		{
		}

		public void ResetFinish()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void OnLevelFightingClick(AGMF_LevelIcon item)
		{
		}

		private void OnAwardClick(AGMF_Award award)
		{
		}

		public void GetRewardFinish()
		{
		}

		private void ShowExtraAwardTips()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
