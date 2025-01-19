using System.Collections.Generic;

namespace WaterBell.LevelDesign
{
	public class MobStatCaculator
	{
		private static MobStatCaculator _instance;

		private Dictionary<long, MobStat> mobStatDict;

		private Dictionary<long, MobFactor> mobFactorDict;

		private List<float[]> levelFactorList;

		private bool isMobStatIntied;

		private bool isMobFactorInited;

		private bool isLevelFactorInited;

		public static MobStatCaculator GetInstance()
		{
			return null;
		}

		public float[] CalcFinalMobStat(long id, int mobType, int lv)
		{
			return null;
		}

		public void ForceRefreshData()
		{
		}

		private void InitParseCSV(bool isForceRefresh = false)
		{
		}

		private bool ParseMobTable()
		{
			return false;
		}

		private bool ParseMobTypeInfoTable()
		{
			return false;
		}

		private bool ParseMobLevelInfoTable()
		{
			return false;
		}
	}
}
