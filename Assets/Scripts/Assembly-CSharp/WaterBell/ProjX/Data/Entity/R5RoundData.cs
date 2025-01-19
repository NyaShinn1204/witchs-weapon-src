using System.Collections.Generic;
using Actionmod;
using Apmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class R5RoundData
	{
		private List<ActivityPlayModeBuffInfo> randomBuffs;

		private List<ActivityPlayModeLevelInfo> currentFloorLevels;

		private int floor;

		private string mobEnhance;

		private int maxFloor;

		public int Floor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<ActivityPlayModeBuffInfo> RandomBuffs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxFloor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string MobEnhance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<ActivityPlayModeLevelInfo> CurrentFloorLevels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ProfitFloor { get; set; }

		public int RoundType { get; set; }

		public double RoundLootModulus { get; set; }

		public int ExtraLootLayer { get; set; }

		public int ExtraLootType { get; set; }

		public int CurProfit { get; set; }

		public int CurBattleScore { get; set; }

		public int BeforeMobLevel { get; set; }

		public int MobLevel { get; set; }

		public int MaxMobLevel { get; set; }

		public R5RoundData(Apmod.R5RoundData r5RoundData)
		{
		}

		public R5RoundData(R5RoundDataExtra r5RoundData)
		{
		}
	}
}
