using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Transactions;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteConnection : DbConnection, ICloneable
	{
		private ConnectionState _connectionState;

		private string _connectionString;

		internal int _transactionLevel;

		private System.Data.IsolationLevel _defaultIsolation;

		internal SQLiteEnlistment _enlistment;

		internal SQLiteBase _sql;

		private string _dataSource;

		private byte[] _password;

		private int _defaultTimeout;

		internal bool _binaryGuid;

		internal long _version;

		private SQLiteUpdateCallback _updateCallback;

		private SQLiteCommitCallback _commitCallback;

		private SQLiteRollbackCallback _rollbackCallback;

		private SQLiteUpdateEventHandler _updateHandler;

		private SQLiteCommitHandler _commitHandler;

		private EventHandler _rollbackHandler;

		private StateChangeEventHandler StateChange;

		[Editor]
		public override string ConnectionString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int DefaultTimeout
		{
			get
			{
				return 0;
			}
		}

		public override ConnectionState State
		{
			get
			{
				return default(ConnectionState);
			}
		}

		protected override DbProviderFactory DbProviderFactory
		{
			get
			{
				return null;
			}
		}

		public SqliteConnection()
		{
		}

		public SqliteConnection(string connectionString)
		{
		}

		public SqliteConnection(SqliteConnection connection)
		{
		}

		public object Clone()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal void OnStateChange(ConnectionState newState)
		{
		}

		public SqliteTransaction BeginTransaction()
		{
			return null;
		}

		protected override DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel)
		{
			return null;
		}

		public override void Close()
		{
		}

		public new SqliteCommand CreateCommand()
		{
			return null;
		}

		protected override DbCommand CreateDbCommand()
		{
			return null;
		}

		internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls)
		{
		}

		internal static string MapMonoUriPath(string path)
		{
			return null;
		}

		internal static string MapUriPath(string path)
		{
			return null;
		}

		internal static SortedList<string, string> ParseConnectionString(string connectionString)
		{
			return null;
		}

		public override void EnlistTransaction(Transaction transaction)
		{
		}

		internal static string FindKey(SortedList<string, string> items, string key, string defValue)
		{
			return null;
		}

		public override void Open()
		{
		}

		private string ExpandFileName(string sourceFile)
		{
			return null;
		}

		public override DataTable GetSchema(string collectionName)
		{
			return null;
		}

		public override DataTable GetSchema(string collectionName, string[] restrictionValues)
		{
			return null;
		}

		private static DataTable Schema_ReservedWords()
		{
			return null;
		}

		private static DataTable Schema_MetaDataCollections()
		{
			return null;
		}

		private DataTable Schema_DataSourceInformation()
		{
			return null;
		}

		private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn)
		{
			return null;
		}

		private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex)
		{
			return null;
		}

		private DataTable Schema_Triggers(string catalog, string table, string triggerName)
		{
			return null;
		}

		private DataTable Schema_Tables(string strCatalog, string strTable, string strType)
		{
			return null;
		}

		private DataTable Schema_Views(string strCatalog, string strView)
		{
			return null;
		}

		private DataTable Schema_Catalogs(string strCatalog)
		{
			return null;
		}

		private DataTable Schema_DataTypes()
		{
			return null;
		}

		private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn)
		{
			return null;
		}

		private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn)
		{
			return null;
		}

		private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName)
		{
			return null;
		}
	}
}
