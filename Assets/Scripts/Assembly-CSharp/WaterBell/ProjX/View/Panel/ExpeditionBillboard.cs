using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ExpeditionBillboard : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UILabel myRankingMiniLabel;

		public GameObject selectBox;

		public GameObject score;

		public UIPanelSingleContainer scoreList;

		public ButtonEx scoreButton;

		public GameObject history;

		public UIPanelSingleContainer historyItems;

		public ButtonEx historyButton;

		public UILabel maxScoreLabel;

		public UILabel myRankingLabel;

		public UILabel totalValueLabel;

		public UILabel progressLabel;

		public UIPanelSingleContainer awardLoots;

		public GameObject typeIconPanel;

		public GameObject rulePanel;

		public ButtonEx closeRuleButton;

		public ButtonEx openRuleButton;

		public UILabel rankingList5Title;

		public UILabel rankingList5Page1;

		public UILabel rankingList5Page1_1;

		public UILabel rankingListPagePast;

		public UILabel rankingListPagePast_1;

		public UILabel rankingListHeader1;

		public UILabel rankingListHeader2;

		public UILabel rankingListHeader3;

		public UILabel rankingList5Rule;

		public UILabel rankingListRuleContentMaze;

		public UILabel rankingListEnd1;

		public UILabel rRankingListHeader1;

		public UILabel rankingListMazeScore1;

		public UILabel rankingListMazeScore2;

		public UILabel rankingListMazeScore3;

		public UILabel rankingList5RewardGet;

		private ExpeditionRankView expeditionRankView;

		private int rankingType;

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
	}
}
