using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.LevelDesign
{
	public class MobFilterDataModel
	{
		private static MobFilterDataModel _instance;

		private SelectLevelDataProvider slDataProvider;

		public long currLevelID;

		public MobLvRange currLvRange;

		public Vector2 mobFilterScrollPos;

		public HeaderRow mobFilterHeaderRow;

		public List<MobDataRow> mobDataList;

		private HashSet<string> mobModelNameSet;

		private MobFilterDataModel()
		{
		}

		public static MobFilterDataModel GetInstance()
		{
			return null;
		}

		public void PrepareLevelMobsData(long levelID)
		{
		}

		public bool IsDataReady(long levelID)
		{
			return false;
		}

		public bool IsAnyMobSelected()
		{
			return false;
		}

		public bool IsMobInFilter(string mobModelName)
		{
			return false;
		}
	}
}
