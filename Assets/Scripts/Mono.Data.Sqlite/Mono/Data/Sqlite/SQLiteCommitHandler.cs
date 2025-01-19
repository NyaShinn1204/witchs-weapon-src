using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SQLiteCommitHandler(object sender, CommitEventArgs e);
}
