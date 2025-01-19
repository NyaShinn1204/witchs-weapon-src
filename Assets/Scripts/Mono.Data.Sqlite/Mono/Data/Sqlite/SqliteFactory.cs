using System;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteFactory : DbProviderFactory, IServiceProvider
	{
		public static readonly SqliteFactory Instance;

		private static Type _dbProviderServicesType;

		private static object _sqliteServices;

		static SqliteFactory()
		{
		}

		object IServiceProvider.GetService(Type serviceType)
		{
			return null;
		}

		public override DbCommand CreateCommand()
		{
			return null;
		}

		public override DbConnection CreateConnection()
		{
			return null;
		}

		public override DbDataAdapter CreateDataAdapter()
		{
			return null;
		}

		public override DbParameter CreateParameter()
		{
			return null;
		}

		private object GetSQLiteProviderServicesInstance()
		{
			return null;
		}
	}
}
