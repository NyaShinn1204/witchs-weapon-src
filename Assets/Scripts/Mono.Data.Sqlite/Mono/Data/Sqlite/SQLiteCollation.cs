using System;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate int SQLiteCollation(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2);
}
