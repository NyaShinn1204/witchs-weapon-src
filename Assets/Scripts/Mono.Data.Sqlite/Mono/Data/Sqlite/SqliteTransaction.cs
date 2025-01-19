using System.Data;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteTransaction : DbTransaction
	{
		internal SqliteConnection _cnn;

		internal long _version;

		private IsolationLevel _level;

		public SqliteConnection Connection
		{
			get
			{
				return null;
			}
		}

		internal SqliteTransaction(SqliteConnection connection, bool deferredLock)
		{
		}

		public override void Commit()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Rollback()
		{
		}

		internal static void IssueRollback(SqliteConnection cnn)
		{
		}

		internal bool IsValid(bool throwError)
		{
			return false;
		}
	}
}
