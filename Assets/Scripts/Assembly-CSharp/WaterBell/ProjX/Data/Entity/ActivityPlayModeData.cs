using System.Collections.Generic;
using Actionmod;
using Apmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ActivityPlayModeData
	{
		private ActivityPlayModeType modeType;

		private R5Data r5Data;

		private R3Data r3Data;

		private R4Data r4Data;

		private R1Data r1Data;

		public string MobEnhance
		{
			get
			{
				return null;
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
		}

		public R1Data Rule1Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public R4Data Rule4Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public R3Data Rule3Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public R5Data Rule5Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActivityPlayModeData(ActivityPlayModeType modeType)
		{
		}

		public static ActivityPlayModeData FromR1DataExtra(R1DataExtra playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromRule2Data(R2Data playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromR2DataExtra(R2DataExtra playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromRule3Data(Apmod.R3Data playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromR3DataExtra(R3DataExtra playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromRule4Data(Apmod.R4Data playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromR4DataExtra(R4DataExtra playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromRule5Data(Apmod.R5Data playData)
		{
			return null;
		}

		public static ActivityPlayModeData FromR5DataExtra(R5DataExtra playData)
		{
			return null;
		}

		public List<ActivityPlayModeBuffInfo> CurrentFloorBuffs()
		{
			return null;
		}

		public List<bool> GetBuffFinishState()
		{
			return null;
		}

		public List<ActivityPlayModeLevelInfo> CurrentFloorLevels()
		{
			return null;
		}

		public R5RoundData GetR5RoundDataByType(int r5RoundType)
		{
			return null;
		}

		public bool GetR5RoundDataUnlockStateByType(int r5RoundType)
		{
			return false;
		}

		public ActivityPlayModeType GetModeType()
		{
			return default(ActivityPlayModeType);
		}
	}
}
