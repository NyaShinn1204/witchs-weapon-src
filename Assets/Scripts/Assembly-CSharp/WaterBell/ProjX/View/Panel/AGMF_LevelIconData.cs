using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AGMF_LevelIconData : UIDataBase
	{
		public long newUnlockLevel;

		public bool isLock;

		public bool isPass;

		public long lastLayer;

		public int layer;

		public bool hasExtraAward;

		public long buffId;

		public AGMF_LevelIconData(long id, bool isLock, bool isPass, long lastLayer, int layer, bool hasExtraAward, long buffId)
		{
		}
	}
}
