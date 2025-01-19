using System;
using System.Data.Common;
using System.Runtime.Serialization;

namespace Mono.Data.Sqlite
{
	[Serializable]
	public sealed class SqliteException : DbException
	{
		private SQLiteErrorCode _errorCode;

		private static string[] _errorMessages;

		private SqliteException(SerializationInfo info, StreamingContext context)
		{
		}

		public SqliteException(int errorCode, string extendedInformation)
		{
		}

		public SqliteException(string message)
		{
		}

		public SqliteException()
		{
		}

		private static string GetStockErrorMessage(int errorCode, string errorMessage)
		{
			return null;
		}
	}
}
