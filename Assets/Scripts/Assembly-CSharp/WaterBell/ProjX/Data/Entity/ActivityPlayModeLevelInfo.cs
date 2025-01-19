using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ActivityPlayModeLevelInfo
	{
		public long LevelId { get; set; }

		public bool Passed { get; set; }

		public int BattleCount { get; set; }

		public bool IsBuffLevel { get; set; }

		public string MobEnhance { get; set; }

		public bool GetReward { get; set; }

		public List<ActivityPlayModeBuffInfo> RelatedBuff { get; set; }

		public int BattleScore { get; set; }
	}
}
