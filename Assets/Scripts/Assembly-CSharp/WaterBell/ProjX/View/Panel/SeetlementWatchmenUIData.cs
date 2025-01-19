using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class SeetlementWatchmenUIData : UIDataBase
	{
		public int rankPrev;

		public int rank;

		public int levelPrev;

		public int level;

		public long expPrev;

		public long exp;

		public int starPrev;

		public int star;

		public long rid;

		public SeetlementWatchmenUIData(long id, int rankPrev, int rank, int levelPrev, int level, long expPrev, long exp, int starPrev, int star, long rid)
		{
		}
	}
}
