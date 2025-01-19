using System;

namespace Mono.Data.Sqlite
{
	internal class SQLite3_UTF16 : SQLite3
	{
		internal SQLite3_UTF16(SQLiteDateFormats fmt)
			: base(default(SQLiteDateFormats))
		{
		}

		public override string ToString(IntPtr b, int nbytelen)
		{
			return null;
		}

		public static string UTF16ToString(IntPtr b, int nbytelen)
		{
			return null;
		}

		internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool)
		{
		}

		internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt)
		{
		}

		internal override void Bind_Text(SqliteStatement stmt, int index, string value)
		{
		}

		internal override DateTime GetDateTime(SqliteStatement stmt, int index)
		{
			return default(DateTime);
		}

		internal override string ColumnName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override string GetText(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override string ColumnOriginalName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override string ColumnDatabaseName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override string ColumnTableName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override string GetParamValueText(IntPtr ptr)
		{
			return null;
		}

		internal override void ReturnError(IntPtr context, string value)
		{
		}

		internal override void ReturnText(IntPtr context, string value)
		{
		}
	}
}
