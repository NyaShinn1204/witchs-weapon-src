using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class ARPRuneDetailData : UIDataBase
	{
		public long runeType;

		public RuneIconData rune;

		public string name;

		public int level;

		public List<AttributeItemData> attributeItemDatas;

		public ARPRuneDetailData(long id, long runeType, int level)
		{
		}
	}
}
