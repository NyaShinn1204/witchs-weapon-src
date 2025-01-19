using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class AGBP_ItemData : UIDataBase
	{
		public string name;

		public int level;

		public long currency;

		public int title;

		public int index;

		public long headID;

		public long headBoxID;

		public double ce;

		public List<LDL_WeaponAndSVIconData> weaponAndSvDataList;

		public float hp;

		public int time;

		public AGBP_ItemData(long id, string name, int level, long currency, int title, int index, long headID, long headBoxID, double ce, List<LDL_WeaponAndSVIconData> weaponAndSvDataList, float hp, int time)
		{
		}
	}
}
