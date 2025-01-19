using System;

namespace Mono.Data.Sqlite
{
	internal class SQLite3 : SQLiteBase
	{
		protected SqliteConnectionHandle _sql;

		protected string _fileName;

		protected bool _usePool;

		protected int _poolVersion;

		private bool _buildingSchema;

		protected SqliteFunction[] _functionsArray;

		internal override string Version
		{
			get
			{
				return null;
			}
		}

		internal static string SQLiteVersion
		{
			get
			{
				return null;
			}
		}

		internal override int Changes
		{
			get
			{
				return 0;
			}
		}

		internal SQLite3(SQLiteDateFormats fmt)
			: base(default(SQLiteDateFormats))
		{
		}

		protected override void Dispose(bool bDisposing)
		{
		}

		internal override void Close()
		{
		}

		internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool)
		{
		}

		internal override void SetTimeout(int nTimeoutMS)
		{
		}

		internal override bool Step(SqliteStatement stmt)
		{
			return false;
		}

		internal override int Reset(SqliteStatement stmt)
		{
			return 0;
		}

		internal override string SQLiteLastError()
		{
			return null;
		}

		internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain)
		{
			strRemain = null;
			return null;
		}

		internal override void Bind_Double(SqliteStatement stmt, int index, double value)
		{
		}

		internal override void Bind_Int32(SqliteStatement stmt, int index, int value)
		{
		}

		internal override void Bind_Int64(SqliteStatement stmt, int index, long value)
		{
		}

		internal override void Bind_Text(SqliteStatement stmt, int index, string value)
		{
		}

		internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt)
		{
		}

		internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData)
		{
		}

		internal override void Bind_Null(SqliteStatement stmt, int index)
		{
		}

		internal override int Bind_ParamCount(SqliteStatement stmt)
		{
			return 0;
		}

		internal override string Bind_ParamName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override int ColumnCount(SqliteStatement stmt)
		{
			return 0;
		}

		internal override string ColumnName(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index)
		{
			return default(TypeAffinity);
		}

		internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity)
		{
			nAffinity = default(TypeAffinity);
			return null;
		}

		internal override int ColumnIndex(SqliteStatement stmt, string columnName)
		{
			return 0;
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

		internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement)
		{
			dataType = null;
			collateSequence = null;
			notNull = default(bool);
			primaryKey = default(bool);
			autoIncrement = default(bool);
		}

		internal override double GetDouble(SqliteStatement stmt, int index)
		{
			return 0.0;
		}

		internal override int GetInt32(SqliteStatement stmt, int index)
		{
			return 0;
		}

		internal override long GetInt64(SqliteStatement stmt, int index)
		{
			return 0L;
		}

		internal override string GetText(SqliteStatement stmt, int index)
		{
			return null;
		}

		internal override DateTime GetDateTime(SqliteStatement stmt, int index)
		{
			return default(DateTime);
		}

		internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			return 0L;
		}

		internal override bool IsNull(SqliteStatement stmt, int index)
		{
			return false;
		}

		internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal)
		{
		}

		internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16)
		{
		}

		internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			return 0L;
		}

		internal override double GetParamValueDouble(IntPtr ptr)
		{
			return 0.0;
		}

		internal override long GetParamValueInt64(IntPtr ptr)
		{
			return 0L;
		}

		internal override string GetParamValueText(IntPtr ptr)
		{
			return null;
		}

		internal override TypeAffinity GetParamValueType(IntPtr ptr)
		{
			return default(TypeAffinity);
		}

		internal override void ReturnBlob(IntPtr context, byte[] value)
		{
		}

		internal override void ReturnDouble(IntPtr context, double value)
		{
		}

		internal override void ReturnError(IntPtr context, string value)
		{
		}

		internal override void ReturnInt64(IntPtr context, long value)
		{
		}

		internal override void ReturnNull(IntPtr context)
		{
		}

		internal override void ReturnText(IntPtr context, string value)
		{
		}

		internal override IntPtr AggregateContext(IntPtr context)
		{
			return (IntPtr)0;
		}

		internal override void SetPassword(byte[] passwordBytes)
		{
		}

		internal override void SetUpdateHook(SQLiteUpdateCallback func)
		{
		}

		internal override void SetCommitHook(SQLiteCommitCallback func)
		{
		}

		internal override void SetRollbackHook(SQLiteRollbackCallback func)
		{
		}

		internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ)
		{
			return null;
		}

		internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage)
		{
			return 0;
		}

		internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor)
		{
			return 0L;
		}

		internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence)
		{
			sortMode = default(int);
			onError = default(int);
			collationSequence = null;
		}
	}
}
