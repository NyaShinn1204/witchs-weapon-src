using System.Collections.Generic;
using System.Data;

namespace WaterBell.ProjX.Data.Entity
{
	public class GameDataGenerator
	{
		public static string GetFilePath(string name)
		{
			return null;
		}

		private static string GetTableName<T>()
		{
			return null;
		}

		public static Dictionary<long, T> GetTableDatas<T>() where T : struct
		{
			return null;
		}

		public static Dictionary<string, T> GetConstantTableDatas<T>() where T : struct
		{
			return null;
		}

		public static DataTable OpenCSV(string filePath)
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
	}
}
