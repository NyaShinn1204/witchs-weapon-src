using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMF_AwardPanel : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UIPanelSingleContainer buff;

		public UIPanelSingleContainer loot;

		public UIPanelSingleContainer extra;

		public UIGrid mainGrid;

		public UILabel activity4VictoryTitleLabel;

		public UILabel activity4Victory1Label;

		public UILabel activity4Victory2Label;

		public UILabel activity4Victory3Label;

		public UILabel activity4Victory4Label;

		private Action OnCloseCallback;

		protected override void Awake()
		{
		}

		public void OpenPanel(List<AGMF_AwardData> buffData, List<LotteryLootData> lootData, List<LotteryLootData> extraLootData, Action onCloseCallback)
		{
		}
	}
}
