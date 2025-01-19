using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SQLiteUpdateEventHandler(object sender, UpdateEventArgs e);
}
