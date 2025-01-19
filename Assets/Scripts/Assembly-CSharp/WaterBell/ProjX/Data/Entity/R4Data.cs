using System.Collections.Generic;
using Actionmod;
using Apmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class R4Data
	{
		private int floor;

		private int maxFloor;

		private string mobEnhance;

		private List<ActivityPlayModeLevelInfo> currentFloorLevels;

		private List<ActivityPlayModeBuffInfo> currentFloorBuffs;

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

		public int RoundType { get; set; }

		public int BeforeMobLevel { get; set; }

		public int ProfitFloor { get; set; }

		public double RoundLootModulus { get; set; }

		public int ExtraLootLayer { get; set; }

		public int ExtraLootType { get; set; }

		public int CurProfit { get; set; }

		public int MobLevel { get; set; }

		public int MaxMobLevel { get; set; }

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

		public List<ActivityPlayModeBuffInfo> CurrentFloorBuffs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public R4Data(Apmod.R4Data playData)
		{
		}

		public R4Data(R4DataExtra playData)
		{
		}
	}
}
