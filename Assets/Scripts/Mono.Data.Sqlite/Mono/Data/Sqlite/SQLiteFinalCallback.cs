using System;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate void SQLiteFinalCallback(IntPtr context);
}
