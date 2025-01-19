using System;

namespace Mono.Data.Sqlite
{
	internal sealed class SqliteStatement : IDisposable
	{
		internal SQLiteBase _sql;

		internal string _sqlStatement;

		internal SqliteStatementHandle _sqlite_stmt;

		internal int _unnamedParameters;

		internal string[] _paramNames;

		internal SqliteParameter[] _paramValues;

		internal SqliteCommand _command;

		private string[] _types;

		internal string[] TypeDefinitions
		{
			get
			{
				return null;
			}
		}

		internal SqliteStatement(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous)
		{
		}

		internal bool MapParameter(string s, SqliteParameter p)
		{
			return false;
		}

		public void Dispose()
		{
		}

		internal void BindParameters()
		{
		}

		private void BindParameter(int index, SqliteParameter param)
		{
		}

		internal void SetTypes(string typedefs)
		{
		}
	}
}
