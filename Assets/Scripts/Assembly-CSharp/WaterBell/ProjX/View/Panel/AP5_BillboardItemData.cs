using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AP5_BillboardItemData : AGBP_ItemData
	{
		public AP5_BillboardItemData(long id, string name, int level, long currency, int title, int index, long headID, long headBoxID, double ce, List<LDL_WeaponAndSVIconData> weaponAndSvDataList, float hp, int time)
			: base(0L, null, 0, 0L, 0, 0, 0L, 0L, 0.0, null, 0f, 0)
		{
		}
	}
}
