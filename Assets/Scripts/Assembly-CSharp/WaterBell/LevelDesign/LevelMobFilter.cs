using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WaterBell.LevelDesign
{
	public class LevelMobFilter
	{
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		private struct FilterData
		{
			public string idSetString;

			public MobLvRange lvRng;

			public int playerCfgID;
		}

		private static LevelMobFilter _instance;

		private bool isInited;

		private Dictionary<long, FilterData> mobFilterInfoDict;

		public static LevelMobFilter GetInstance()
		{
			return null;
		}

		public void RefreshData()
		{
		}

		private void InitParseCSV()
		{
		}

		public MobLvRange GetMobLvRange(long levelID)
		{
			return default(MobLvRange);
		}

		public string GetMobIDSetString(long levelID)
		{
			return null;
		}

		public int GetPlayerCfgID(long levelID)
		{
			return 0;
		}
	}
}
