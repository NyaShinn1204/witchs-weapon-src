using Mono.Data.Sqlite;

namespace WaterBell.ProjX.Common.SqliteUtil
{
	public class SqlliteHelper
	{
		private SqliteConnection dbConnection;

		private SqliteCommand dbCommand;

		private SqliteDataReader reader;

		public void OpenDB(string connectionString)
		{
		}

		public void CloseSqlConnection()
		{
		}

		public SqliteDataReader ExecuteQuery(string sqlQuery)
		{
			return null;
		}

		public SqliteDataReader ReadFullTable(string tableName)
		{
			return null;
		}

		public SqliteDataReader SelectWithDictInfo(string tableName, string[] colNames, int[] dictIDPosIdxArr, string ValueSetStr = "", string ValueColName = "ID", OrderByInfo obInfo = null)
		{
			return null;
		}

		public SqliteDataReader SelectAll(string tableName, string[] items)
		{
			return null;
		}

		public SqliteDataReader SelectWhere(string tableName, string[] items, string[] col, string[] operation, string[] values)
		{
			return null;
		}

		public SqliteDataReader SelectWhereUnsafe(string tableName, string[] items, string[] col, string[] operation, string[] values)
		{
			return null;
		}
	}
}
