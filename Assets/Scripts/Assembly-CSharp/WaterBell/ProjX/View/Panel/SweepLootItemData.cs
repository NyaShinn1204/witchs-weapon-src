using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class SweepLootItemData : UIDataBase
	{
		public long gold;

		public long exp;

		public List<UIDataBase> lootItemList;

		public SweepLootItemData(long id, List<UIDataBase> lootItemList, long gold, long exp)
		{
		}
	}
}
