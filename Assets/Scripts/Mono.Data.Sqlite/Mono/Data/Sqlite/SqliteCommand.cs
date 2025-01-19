using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteCommand : DbCommand, ICloneable
	{
		private string _commandText;

		private SqliteConnection _cnn;

		private long _version;

		private WeakReference _activeReader;

		internal int _commandTimeout;

		private bool _designTimeVisible;

		private UpdateRowSource _updateRowSource;

		private SqliteParameterCollection _parameterCollection;

		internal List<SqliteStatement> _statementList;

		internal string _remainingText;

		private SqliteTransaction _transaction;

		[Editor]
		public override string CommandText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int CommandTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override CommandType CommandType
		{
			set
			{
			}
		}

		[Editor]
		public new SqliteConnection Connection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override DbConnection DbConnection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new SqliteParameterCollection Parameters
		{
			get
			{
				return null;
			}
		}

		protected override DbParameterCollection DbParameterCollection
		{
			get
			{
				return null;
			}
		}

		public new SqliteTransaction Transaction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override DbTransaction DbTransaction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override UpdateRowSource UpdatedRowSource
		{
			get
			{
				return default(UpdateRowSource);
			}
			set
			{
			}
		}

		[EditorBrowsable]
		public override bool DesignTimeVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SqliteCommand()
		{
		}

		public SqliteCommand(string commandText, SqliteConnection connection)
		{
		}

		public SqliteCommand(SqliteConnection connection)
		{
		}

		private SqliteCommand(SqliteCommand source)
		{
		}

		public SqliteCommand(string commandText, SqliteConnection connection, SqliteTransaction transaction)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal void ClearCommands()
		{
		}

		internal SqliteStatement BuildNextCommand()
		{
			return null;
		}

		internal SqliteStatement GetStatement(int index)
		{
			return null;
		}

		protected override DbParameter CreateDbParameter()
		{
			return null;
		}

		public new SqliteParameter CreateParameter()
		{
			return null;
		}

		private void InitializeForReader()
		{
		}

		protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
		{
			return null;
		}

		public new SqliteDataReader ExecuteReader(CommandBehavior behavior)
		{
			return null;
		}

		public SqliteDataReader ExecuteReader()
		{
			return null;
		}

		internal void ClearDataReader()
		{
		}

		public override int ExecuteNonQuery()
		{
			return 0;
		}

		public object Clone()
		{
			return null;
		}
	}
}
