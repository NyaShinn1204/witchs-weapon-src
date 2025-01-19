using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteParameter : DbParameter, ICloneable
	{
		internal int _dbType;

		private DataRowVersion _rowVersion;

		private object _objValue;

		private string _sourceColumn;

		private string _parameterName;

		private int _dataSize;

		private bool _nullable;

		private bool _nullMapping;

		public override bool IsNullable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override DbType DbType
		{
			get
			{
				return default(DbType);
			}
			set
			{
			}
		}

		public override ParameterDirection Direction
		{
			get
			{
				return default(ParameterDirection);
			}
			set
			{
			}
		}

		public override string ParameterName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int Size
		{
			set
			{
			}
		}

		public override string SourceColumn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool SourceColumnNullMapping
		{
			set
			{
			}
		}

		public override DataRowVersion SourceVersion
		{
			get
			{
				return default(DataRowVersion);
			}
			set
			{
			}
		}

		[TypeConverter]
		public override object Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SqliteParameter()
		{
		}

		public SqliteParameter(string parameterName, object value)
		{
		}

		public SqliteParameter(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion)
		{
		}

		private SqliteParameter(SqliteParameter source)
		{
		}

		[EditorBrowsable]
		public SqliteParameter(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
