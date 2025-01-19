using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class LDL_ItemData : UIDataBase
	{
		public int level;

		public string name;

		public List<LDL_WeaponAndSVIconData> weaponAndSvDataList;

		public double ce;

		public float hp;

		public int time;

		public int index;

		public LDL_ItemData(long id, double ce, List<LDL_WeaponAndSVIconData> weaponAndSvDataList, int level, string name, float hp, int time, int index)
		{
		}
	}
}
