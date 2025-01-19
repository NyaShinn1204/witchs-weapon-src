using System;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	internal class SqliteConnectionHandle : CriticalHandle
	{
		public override bool IsInvalid
		{
			get
			{
				return false;
			}
		}

		private SqliteConnectionHandle(IntPtr db)
			: base((IntPtr)0)
		{
		}

		internal SqliteConnectionHandle()
			: base((IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		public static implicit operator IntPtr(SqliteConnectionHandle db)
		{
			return (IntPtr)0;
		}

		public static implicit operator SqliteConnectionHandle(IntPtr db)
		{
			return null;
		}
	}
}
