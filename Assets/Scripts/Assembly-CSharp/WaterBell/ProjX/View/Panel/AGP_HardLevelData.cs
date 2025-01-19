using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class AGP_HardLevelData : UIDataBase
	{
		public int layer;

		public List<BuffIconData> buffList;

		public int index;

		public long enemyBuffId;

		public AGP_HardLevelData(long id, int layer, List<BuffIconData> buffList, int index, long enemyBuffId)
		{
		}
	}
}
