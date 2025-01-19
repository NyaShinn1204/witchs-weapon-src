using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class RoleIconItemData : UIDataBase
	{
		public long levelID;

		public int level;

		public int quality;

		public int star;

		public int type;

		public string icon;

		public int slotIdx;

		public bool isEnemy;

		public string mobStage;

		public RoleIconItemData(long id, long levelID, int level, int slotIdx, int type, bool isEnemy = true)
		{
		}

		private void ResolveDataDetail(RoleIconItemData roleData)
		{
		}
	}
}
