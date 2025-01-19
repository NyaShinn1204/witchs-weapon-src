namespace WaterBell.ProjX.View.Panel
{
	public class LotteryNewPanelData : UIDataBase
	{
		public LuckDrawTypes luckDrawType;

		public int sortIndex;

		public long drawBaseId;

		public LotteryNewPanelData(LuckDrawTypes luckDrawType, int sortIndex = -1)
		{
		}

		public LotteryNewPanelData(long drawBaseId)
		{
		}
	}
}
