using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class EquipDetailPanelCacheData : UIDataBase
	{
		public ForgeInfo rootForgeInfo;

		public int? serviceDuct;

		public ForgeInfo currentForgeInfo;

		public Vector3 pos;

		public int summarySelectIndex;

		public long rootEquipId;

		public int rankUpEquipSelectIndex;

		public EquipDetailPanelCacheData(ForgeInfo rootForgeInfo, int? serviceDuct, ForgeInfo currentForgeInfo, Vector3 pos)
		{
		}
	}
}
