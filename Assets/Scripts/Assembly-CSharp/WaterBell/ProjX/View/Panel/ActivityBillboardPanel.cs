using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityBillboardPanel : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UIPanelSingleContainer scoreList;

		public UILabel rankingList5Type;

		public UILabel rankingList5Title;

		public UILabel rankingListHeader1;

		public UILabel rankingListHeader2;

		public UILabel rankingListHeader3;

		public UILabel rankingListEnd1;

		public UILabel rankingList5Rank;

		public UILabel rankingList5Score;

		public UILabel rankingList5Score1;

		public UILabel rankingList5Score2;

		public UILabel rankingList5Score3;

		public UILabel rankingList5TotalScore;

		public UILabel rankingList5Reward;

		public UILabel myRankingMiniLabel;

		public ButtonEx openRuleButton;

		public UILabel rankingList5RewardGet;

		public GameObject selectBox;

		public UIGrid buttonContent;

		public UILabel myRankingLabel;

		public UILabel ranking1ValueLabel;

		public UILabel ranking2ValueLabel;

		public UILabel ranking3ValueLabel;

		public UILabel totalValueLabel;

		public GameObject top3;

		public UIPanelSingleContainer awardLoots;

		public GameObject typeIconPanel;

		public GameObject rulePanel;

		public UILabel rankingList5RuleTitle;

		public UILabel rankingList5RuleDesc;

		public ButtonEx closeRuleButton;

		private ButtonEx selectButton;

		private ActivityPlayRankView activityPlayRankView;

		private List<AP5_BillboardItemData> scoreDataList;

		private int selectIndex;

		protected override void Awake()
		{
		}

		private void Select(ButtonEx pageButton)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void Close()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
