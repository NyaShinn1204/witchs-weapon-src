using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class RankData
	{
		public List<RankInfo> Top;

		public long Data;

		public int Rank;

		public long NextRankTime;

		public int RankType;

		public int RankPage;

		public int Section;

		public List<int> DataArr;

		public List<RankLevelInfo> RankLevelInfos;

		public long BestScore;
	}
}
