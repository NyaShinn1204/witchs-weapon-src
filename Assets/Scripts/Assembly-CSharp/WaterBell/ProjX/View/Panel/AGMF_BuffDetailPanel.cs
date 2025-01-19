using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMF_BuffDetailPanel : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UIPanelSingleContainer loot;

		public UILabel intelligenceValueLabel;

		public UILabel intelligenceNameLabel;

		public UILabel buffCountLabel;

		public UILabel activity4Intelligence3Label;

		protected override void Awake()
		{
		}

		public void OpenPanel(List<LotteryLootData> lootData, float buffValue)
		{
		}
	}
}
