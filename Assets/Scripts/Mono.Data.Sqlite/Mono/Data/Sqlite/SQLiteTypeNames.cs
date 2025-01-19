using System.Data;
using System.Runtime.InteropServices;

namespace Mono.Data.Sqlite
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	internal struct SQLiteTypeNames
	{
		internal string typeName;

		internal DbType dataType;

		internal SQLiteTypeNames(string newtypeName, DbType newdataType)
		{
			typeName = null;
			dataType = default(DbType);
		}
	}
}
