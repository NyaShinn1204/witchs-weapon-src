using System;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate void SQLiteUpdateCallback(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid);
}
