using System.Collections.Generic;

public class ManagerOfflineIO
{
	public enum OfflineType
	{
		NULL = 0,
		save = 1,
		read = 2
	}

	public class TypeOffline
	{
		public string id;

		public string val;

		public string tag;

		public string url;
	}

	public static OfflineType type;

	private static bool _isInit;

	private static Dictionary<string, List<TypeOffline>> _offline;

	public static bool isRead
	{
		get
		{
			return false;
		}
	}

	public static bool isSave
	{
		get
		{
			return false;
		}
	}

	private static string url
	{
		get
		{
			return null;
		}
	}

	private static string urlCsv
	{
		get
		{
			return null;
		}
	}

	private static void initCache()
	{
	}

	protected static void save()
	{
	}

	public static void saveData(string sSendID, string sSendVal, string sTag, byte[] sBytes)
	{
	}

	public static byte[] readData(string sSendID, string sSendVal)
	{
		return null;
	}

	public static string readTag(string sSendID, string sSendVal)
	{
		return null;
	}
}
