using System;

namespace Mono.Data.Sqlite
{
	internal abstract class SQLiteBase : SqliteConvert, IDisposable
	{
		internal static object _lock;

		internal abstract string Version { get; }

		internal abstract int Changes { get; }

		internal SQLiteBase(SQLiteDateFormats fmt)
			: base(default(SQLiteDateFormats))
		{
		}

		internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

		internal abstract void Close();

		internal abstract void SetTimeout(int nTimeoutMS);

		internal abstract string SQLiteLastError();

		internal abstract SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain);

		internal abstract bool Step(SqliteStatement stmt);

		internal abstract int Reset(SqliteStatement stmt);

		internal abstract void Bind_Double(SqliteStatement stmt, int index, double value);

		internal abstract void Bind_Int32(SqliteStatement stmt, int index, int value);

		internal abstract void Bind_Int64(SqliteStatement stmt, int index, long value);

		internal abstract void Bind_Text(SqliteStatement stmt, int index, string value);

		internal abstract void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData);

		internal abstract void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt);

		internal abstract void Bind_Null(SqliteStatement stmt, int index);

		internal abstract int Bind_ParamCount(SqliteStatement stmt);

		internal abstract string Bind_ParamName(SqliteStatement stmt, int index);

		internal abstract int ColumnCount(SqliteStatement stmt);

		internal abstract string ColumnName(SqliteStatement stmt, int index);

		internal abstract TypeAffinity ColumnAffinity(SqliteStatement stmt, int index);

		internal abstract string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity);

		internal abstract int ColumnIndex(SqliteStatement stmt, string columnName);

		internal abstract string ColumnOriginalName(SqliteStatement stmt, int index);

		internal abstract string ColumnDatabaseName(SqliteStatement stmt, int index);

		internal abstract string ColumnTableName(SqliteStatement stmt, int index);

		internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

		internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

		internal abstract double GetDouble(SqliteStatement stmt, int index);

		internal abstract int GetInt32(SqliteStatement stmt, int index);

		internal abstract long GetInt64(SqliteStatement stmt, int index);

		internal abstract string GetText(SqliteStatement stmt, int index);

		internal abstract long GetBytes(SqliteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

		internal abstract DateTime GetDateTime(SqliteStatement stmt, int index);

		internal abstract bool IsNull(SqliteStatement stmt, int index);

		internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16);

		internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

		internal abstract IntPtr AggregateContext(IntPtr context);

		internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

		internal abstract double GetParamValueDouble(IntPtr ptr);

		internal abstract long GetParamValueInt64(IntPtr ptr);

		internal abstract string GetParamValueText(IntPtr ptr);

		internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

		internal abstract void ReturnBlob(IntPtr context, byte[] value);

		internal abstract void ReturnDouble(IntPtr context, double value);

		internal abstract void ReturnError(IntPtr context, string value);

		internal abstract void ReturnInt64(IntPtr context, long value);

		internal abstract void ReturnNull(IntPtr context);

		internal abstract void ReturnText(IntPtr context, string value);

		internal abstract void SetPassword(byte[] passwordBytes);

		internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

		internal abstract void SetCommitHook(SQLiteCommitCallback func);

		internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

		internal abstract int GetCursorForTable(SqliteStatement stmt, int database, int rootPage);

		internal abstract long GetRowIdForCursor(SqliteStatement stmt, int cursor);

		internal abstract object GetValue(SqliteStatement stmt, int index, SQLiteType typ);

		protected virtual void Dispose(bool bDisposing)
		{
		}

		public void Dispose()
		{
		}

		internal static string SQLiteLastError(SqliteConnectionHandle db)
		{
			return null;
		}

		internal static void FinalizeStatement(SqliteStatementHandle stmt)
		{
		}

		internal static void CloseConnection(SqliteConnectionHandle db)
		{
		}

		internal static void ResetConnection(SqliteConnectionHandle db)
		{
		}
	}
}
