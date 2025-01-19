using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AGMO_PropAddItemData : AGMO_PropItemData
	{
		public long myCurrency;

		public long targetLevel;

		public long needCurrency;

		public long maxLevel;

		public AGMO_PropAddItemData(long level, int propID, long myCurrency, long targetLevel)
			: base(0L, 0)
		{
		}
	}
}
