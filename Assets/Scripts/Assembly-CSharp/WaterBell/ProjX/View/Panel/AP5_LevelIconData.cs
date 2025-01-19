using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AP5_LevelIconData : AGMF_LevelIconData
	{
		public AP5_LevelIconData(long id, bool isLock, bool isPass, long lastLayer, int layer, bool hasExtraAward, long buffId)
			: base(0L, false, false, 0L, 0, false, 0L)
		{
		}
	}
}
