using System.Data;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteCommandBuilder : DbCommandBuilder
	{
		public new SqliteDataAdapter DataAdapter
		{
			set
			{
			}
		}

		public override string QuotePrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string QuoteSuffix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SqliteCommandBuilder()
		{
		}

		public SqliteCommandBuilder(SqliteDataAdapter adp)
		{
		}

		protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
		{
		}

		protected override string GetParameterName(string parameterName)
		{
			return null;
		}

		protected override string GetParameterName(int parameterOrdinal)
		{
			return null;
		}

		protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
		{
		}

		private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e)
		{
		}

		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			return null;
		}

		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			return null;
		}
	}
}
