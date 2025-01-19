using System.Collections.Generic;

namespace WaterBell.LevelDesign
{
	public class SelectLevelDataProvider
	{
		private static SelectLevelDataProvider _instance;

		private DataQuery dqAgent;

		private LevelMobFilter mobFilter;

		public static SelectLevelDataProvider GetInstance()
		{
			return null;
		}

		public void RefreshData()
		{
		}

		public List<CustomDataRow> GetLevelSetList()
		{
			return null;
		}

		public List<CustomDataRow> GetLevelDetailList(long levelSetID)
		{
			return null;
		}

		public string GetLevelMobsIDSetStr(long levelID)
		{
			return null;
		}

		public List<MobDataRow> GetLevelMobDataList(long levelID)
		{
			return null;
		}

		public MobLvRange GetLevelMobsLvRange(long levelID)
		{
			return default(MobLvRange);
		}
	}
}
