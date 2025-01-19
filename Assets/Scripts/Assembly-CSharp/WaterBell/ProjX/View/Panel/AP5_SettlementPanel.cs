using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AP5_SettlementPanel : UIPanelSingle
	{
		public UILabel scoreLabel;

		public GameObject scoreContainer;

		public GameObject loot2;

		public GameObject otherInfo;

		public UIPanelSingleContainer loot1Icon;

		public UIPanelSingleContainer loot2Icon;

		public UILabel SettlementActivityGameReward;

		public UILabel SettlementActivityGameBonus;

		public UILabel SettlementActivityGameScore6;

		public AP5_SettlementOtherInfoItem item1;

		public AP5_SettlementOtherInfoItem item2;

		public AP5_SettlementOtherInfoItem item3;

		public AP5_SettlementOtherInfoItem item4;

		public AP5_SettlementOtherInfoItem item5;

		public override void OpenPanel(UIDataBase mData = null)
		{
		}
	}
}
