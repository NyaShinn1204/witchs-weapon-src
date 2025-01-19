using System;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	internal class SqliteStatementHandle : CriticalHandle
	{
		public override bool IsInvalid
		{
			get
			{
				return false;
			}
		}

		private SqliteStatementHandle(IntPtr stmt)
			: base((IntPtr)0)
		{
		}

		internal SqliteStatementHandle()
			: base((IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		public static implicit operator IntPtr(SqliteStatementHandle stmt)
		{
			return (IntPtr)0;
		}

		public static implicit operator SqliteStatementHandle(IntPtr stmt)
		{
			return null;
		}
	}
}
