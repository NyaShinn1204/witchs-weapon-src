using System.Collections.Generic;
using WaterBell.LevelDesign;

namespace WaterBell.ProjX.Common.SqliteUtil
{
	public class SqlQuery
	{
		public static string getField<T>(string tableName, string colName, string id)
		{
			return null;
		}

		public List<CustomDataRow> GetLevelSetList()
		{
			return null;
		}

		public List<MobDataRow> GetLevelMobDataList(string mobIDSetStr, MobLvRange rng)
		{
			return null;
		}

		public static long GetServentDebrisByServant(long id)
		{
			return 0L;
		}

		public static Dictionary<long, T> GetTableDatas<T>() where T : struct
		{
			return null;
		}

		public static Dictionary<string, T> GetConstantTableDatas<T>() where T : struct
		{
			return null;
		}

		private static long ToLong(object value)
		{
			return 0L;
		}

		private static int ToInt(object value)
		{
			return 0;
		}

		private static string ToString(object value)
		{
			return null;
		}

		private static bool ToBoolean(object value)
		{
			return false;
		}

		private static string GetTableName<T>()
		{
			return null;
		}
	}
}
