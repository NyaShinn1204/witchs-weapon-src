using System.Collections.Generic;
using Actionmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class R1Data
	{
		private int freeCount;

		private int restCost;

		private int floor;

		private int maxFloor;

		private string mobEnhance;

		private List<ActivityPlayModeLevelInfo> currentFloorLevels;

		private List<ActivityPlayModeBuffInfo> currentFloorBuffs;

		public List<bool> buffsFinishState;

		public List<bool> BuffsFinishState
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

		public int FreeCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RestCost
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public R1Data(R1DataExtra playData)
		{
		}
	}
}
