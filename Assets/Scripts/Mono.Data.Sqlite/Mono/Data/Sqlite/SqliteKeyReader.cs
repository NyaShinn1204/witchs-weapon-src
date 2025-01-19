using System;
using System.Data;

namespace Mono.Data.Sqlite
{
	internal sealed class SqliteKeyReader : IDisposable
	{
		private struct KeyInfo
		{
			internal string databaseName;

			internal string tableName;

			internal string columnName;

			internal int database;

			internal int rootPage;

			internal int cursor;

			internal KeyQuery query;

			internal int column;
		}

		private sealed class KeyQuery : IDisposable
		{
			private SqliteCommand _command;

			internal SqliteDataReader _reader;

			internal bool IsValid
			{
				set
				{
				}
			}

			internal KeyQuery(SqliteConnection cnn, string database, string table, params string[] columns)
			{
			}

			internal void Sync(long rowid)
			{
			}

			public void Dispose()
			{
			}
		}

		private KeyInfo[] _keyInfo;

		private SqliteStatement _stmt;

		private bool _isValid;

		internal int Count
		{
			get
			{
				return 0;
			}
		}

		internal SqliteKeyReader(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt)
		{
		}

		internal void Sync(int i)
		{
		}

		internal void Sync()
		{
		}

		internal void Reset()
		{
		}

		public void Dispose()
		{
		}

		internal string GetDataTypeName(int i)
		{
			return null;
		}

		internal Type GetFieldType(int i)
		{
			return null;
		}

		internal string GetName(int i)
		{
			return null;
		}

		internal int GetOrdinal(string name)
		{
			return 0;
		}

		internal bool GetBoolean(int i)
		{
			return false;
		}

		internal int GetInt32(int i)
		{
			return 0;
		}

		internal long GetInt64(int i)
		{
			return 0L;
		}

		internal string GetString(int i)
		{
			return null;
		}

		internal object GetValue(int i)
		{
			return null;
		}

		internal bool IsDBNull(int i)
		{
			return false;
		}

		internal void AppendSchemaTable(DataTable tbl)
		{
		}
	}
}
