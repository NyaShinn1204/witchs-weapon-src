using System;
using System.Collections;
using System.Data;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteDataReader : DbDataReader
	{
		private SqliteCommand _command;

		private int _activeStatementIndex;

		private SqliteStatement _activeStatement;

		private int _readingState;

		private int _rowsAffected;

		private int _fieldCount;

		private SQLiteType[] _fieldTypeArray;

		private CommandBehavior _commandBehavior;

		internal bool _disposeCommand;

		private SqliteKeyReader _keyInfo;

		internal long _version;

		public override int FieldCount
		{
			get
			{
				return 0;
			}
		}

		public override int VisibleFieldCount
		{
			get
			{
				return 0;
			}
		}

		public override int RecordsAffected
		{
			get
			{
				return 0;
			}
		}

		public override object Item
		{
			get
			{
				return null;
			}
		}

		public override object Item
		{
			get
			{
				return null;
			}
		}

		internal SqliteDataReader(SqliteCommand cmd, CommandBehavior behave)
		{
		}

		public override void Close()
		{
		}

		private void CheckClosed()
		{
		}

		private void CheckValidRow()
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		private TypeAffinity VerifyType(int i, DbType typ)
		{
			return default(TypeAffinity);
		}

		public override bool GetBoolean(int i)
		{
			return false;
		}

		public override string GetDataTypeName(int i)
		{
			return null;
		}

		public override Type GetFieldType(int i)
		{
			return null;
		}

		public override int GetInt32(int i)
		{
			return 0;
		}

		public override long GetInt64(int i)
		{
			return 0L;
		}

		public override string GetName(int i)
		{
			return null;
		}

		public override int GetOrdinal(string name)
		{
			return 0;
		}

		public override DataTable GetSchemaTable()
		{
			return null;
		}

		internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue)
		{
			return null;
		}

		public override string GetString(int i)
		{
			return null;
		}

		public override object GetValue(int i)
		{
			return null;
		}

		public override int GetValues(object[] values)
		{
			return 0;
		}

		public override bool IsDBNull(int i)
		{
			return false;
		}

		public override bool NextResult()
		{
			return false;
		}

		private SQLiteType GetSQLiteType(int i)
		{
			return null;
		}

		public override bool Read()
		{
			return false;
		}

		private void LoadKeyInfo()
		{
		}
	}
}
