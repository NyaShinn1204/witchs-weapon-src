using System;
using System.Data.Common;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteDataAdapter : DbDataAdapter
	{
		private static object _updatingEventPH;

		private static object _updatedEventPH;

		public event EventHandler<RowUpdatingEventArgs> RowUpdating
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static Delegate FindBuilder(MulticastDelegate mcd)
		{
			return null;
		}
	}
}
