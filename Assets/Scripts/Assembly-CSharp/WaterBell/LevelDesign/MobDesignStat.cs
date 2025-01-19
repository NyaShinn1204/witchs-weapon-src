using System.Collections.Generic;

namespace WaterBell.LevelDesign
{
	public class MobDesignStat
	{
		public class MonsterStaticsItem
		{
			public string ID;

			public string name;

			public List<MonsterAttr> list;
		}

		private static MobDesignStat _instance;

		private const int MaxBoss = 1;

		private const int MaxElits = 16;

		private List<MonsterAttr> bossList;

		private List<MonsterAttr> eliteList;

		private List<MonsterAttr> normalList;

		private List<MonsterAttr> invalidList;

		private Dictionary<string, MonsterAttr> MonsterNameTable;

		private List<MonsterStaticsItem> MonsterStats;

		private List<MobDataRow> mobDataList;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public List<MonsterStaticsItem> MonsterStatics
		{
			get
			{
				return null;
			}
		}

		public static MobDesignStat GetInstance()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void AddValid(MonsterAttr mobAttr)
		{
		}

		public void AddInvalid(MonsterAttr mobAttr)
		{
		}

		public void ChangeMobType(MonsterAttr mobAttr, int oldType, int newType)
		{
		}

		public bool IsMobWithinValidNode()
		{
			return false;
		}

		public string GetFirstInvalidMobName()
		{
			return null;
		}

		public bool IsBossValid()
		{
			return false;
		}

		public bool IsEliteValid()
		{
			return false;
		}

		public HashSet<string> GetElitesMergedOutputNames()
		{
			return null;
		}

		public void ShowCount()
		{
		}

		public void MobName4Trigger_CheckMonsterNames(MonsterAttr mobAttr)
		{
		}

		public MonsterAttr MobName4Trigger_GetMonsterAttrByName(string name)
		{
			return null;
		}

		public List<MonsterAttr> MobName4Trigger_GetAllMonsters()
		{
			return null;
		}

		public List<string> MobName4Trigger_GetAllNames()
		{
			return null;
		}

		public void MobName4Trigger_ClearNameTable()
		{
		}

		public bool isMonsterInvalid(MonsterAttr mobAttr)
		{
			return false;
		}

		public void MobStats_CountValidMonster(MonsterAttr m)
		{
		}
	}
}
