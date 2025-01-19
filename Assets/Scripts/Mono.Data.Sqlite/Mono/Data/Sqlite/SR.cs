using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Mono.Data.Sqlite
{
	[DebuggerNonUserCode]
	internal class SR
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable]
		internal static ResourceManager ResourceManager
		{
			get
			{
				return null;
			}
		}

		internal static string DataTypes
		{
			get
			{
				return null;
			}
		}

		internal static string Keywords
		{
			get
			{
				return null;
			}
		}

		internal static string MetaDataCollections
		{
			get
			{
				return null;
			}
		}
	}
}
