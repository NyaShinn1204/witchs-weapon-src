using System.Collections.Generic;

public class ManagerCache
{
	public class TypeCacheWeapon : SuperType
	{
		public long id;

		public int type;

		public int serial;

		public long value;
	}

	public class TypeCacheTeam : SuperType
	{
		public long id;

		public int type;

		public int serial;

		public long[] value;

		public long[] rids;
	}

	private static string _roleID;

	private static Dictionary<int, TypeCacheWeapon> _cacheWeapon;

	private static Dictionary<int, TypeCacheTeam> _cacheTeam;

	private static string url
	{
		get
		{
			return null;
		}
	}

	public static void initCache()
	{
	}

	protected static void save()
	{
	}

	public static void saveData(int sType, int sSerial, long[] sTeam, long[] sRole, Dictionary<long, long> sWeapon)
	{
	}

	public static void RemoveCacheType(int sType)
	{
	}

	public static TypeCacheWeapon getCacheWeapon(long sIDServant, int sType)
	{
		return null;
	}

	public static TypeCacheTeam getCacheTeam(int sType)
	{
		return null;
	}
}
