using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	[Editor]
	public sealed class SqliteParameterCollection : DbParameterCollection
	{
		private SqliteCommand _command;

		private List<SqliteParameter> _parameterList;

		private bool _unboundFlag;

		public override bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public override bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public override object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public override int Count
		{
			get
			{
				return 0;
			}
		}

		public new SqliteParameter Item
		{
			get
			{
				return null;
			}
		}

		internal SqliteParameterCollection(SqliteCommand cmd)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public int Add(SqliteParameter parameter)
		{
			return 0;
		}

		[EditorBrowsable]
		public override int Add(object value)
		{
			return 0;
		}

		public SqliteParameter AddWithValue(string parameterName, object value)
		{
			return null;
		}

		public override void AddRange(Array values)
		{
		}

		public override void Clear()
		{
		}

		public override bool Contains(object value)
		{
			return false;
		}

		public override void CopyTo(Array array, int index)
		{
		}

		protected override DbParameter GetParameter(int index)
		{
			return null;
		}

		public override int IndexOf(string parameterName)
		{
			return 0;
		}

		public override int IndexOf(object value)
		{
			return 0;
		}

		public override void Insert(int index, object value)
		{
		}

		public override void Remove(object value)
		{
		}

		public override void RemoveAt(int index)
		{
		}

		protected override void SetParameter(int index, DbParameter value)
		{
		}

		internal void Unbind()
		{
		}

		internal void MapParameters(SqliteStatement activeStatement)
		{
		}
	}
}
