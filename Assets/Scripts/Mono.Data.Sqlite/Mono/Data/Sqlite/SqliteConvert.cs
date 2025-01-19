using System;
using System.Data;
using System.Text;

namespace Mono.Data.Sqlite
{
	public abstract class SqliteConvert
	{
		private static string[] _datetimeFormats;

		private static Encoding _utf8;

		internal SQLiteDateFormats _datetimeFormat;

		private static Type[] _affinitytotype;

		private static DbType[] _typetodbtype;

		private static int[] _dbtypetocolumnsize;

		private static object[] _dbtypetonumericprecision;

		private static object[] _dbtypetonumericscale;

		private static SQLiteTypeNames[] _dbtypeNames;

		private static Type[] _dbtypeToType;

		private static TypeAffinity[] _typecodeAffinities;

		private static SQLiteTypeNames[] _typeNames;

		internal SqliteConvert(SQLiteDateFormats fmt)
		{
		}

		public static byte[] ToUTF8(string sourceText)
		{
			return null;
		}

		public byte[] ToUTF8(DateTime dateTimeValue)
		{
			return null;
		}

		public virtual string ToString(IntPtr nativestring, int nativestringlen)
		{
			return null;
		}

		public static string UTF8ToString(IntPtr nativestring, int nativestringlen)
		{
			return null;
		}

		public DateTime ToDateTime(string dateText)
		{
			return default(DateTime);
		}

		public DateTime ToDateTime(double julianDay)
		{
			return default(DateTime);
		}

		public double ToJulianDay(DateTime value)
		{
			return 0.0;
		}

		public string ToString(DateTime dateValue)
		{
			return null;
		}

		internal DateTime ToDateTime(IntPtr ptr, int len)
		{
			return default(DateTime);
		}

		public static string[] Split(string source, char separator)
		{
			return null;
		}

		public static bool ToBoolean(string source)
		{
			return false;
		}

		internal static Type SQLiteTypeToType(SQLiteType t)
		{
			return null;
		}

		internal static DbType TypeToDbType(Type typ)
		{
			return default(DbType);
		}

		internal static int DbTypeToColumnSize(DbType typ)
		{
			return 0;
		}

		internal static object DbTypeToNumericPrecision(DbType typ)
		{
			return null;
		}

		internal static object DbTypeToNumericScale(DbType typ)
		{
			return null;
		}

		internal static string DbTypeToTypeName(DbType typ)
		{
			return null;
		}

		internal static Type DbTypeToType(DbType typ)
		{
			return null;
		}

		internal static TypeAffinity TypeToAffinity(Type typ)
		{
			return default(TypeAffinity);
		}

		internal static DbType TypeNameToDbType(string Name)
		{
			return default(DbType);
		}
	}
}
