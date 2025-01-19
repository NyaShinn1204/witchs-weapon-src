using System.Transactions;

namespace Mono.Data.Sqlite
{
	internal class SQLiteEnlistment : IEnlistmentNotification
	{
		internal SqliteTransaction _transaction;

		internal Transaction _scope;

		internal bool _disposeConnection;

		internal SQLiteEnlistment(SqliteConnection cnn, Transaction scope)
		{
		}

		private void Cleanup(SqliteConnection cnn)
		{
		}

		public void Commit(Enlistment enlistment)
		{
		}

		public void Prepare(PreparingEnlistment preparingEnlistment)
		{
		}

		public void Rollback(Enlistment enlistment)
		{
		}
	}
}
