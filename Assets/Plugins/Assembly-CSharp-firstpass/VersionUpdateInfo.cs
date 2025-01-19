using System.Collections.Generic;

public class VersionUpdateInfo
{
	public enum STATE
	{
		NO_NEWEST = 0,
		SHOULD_UPDATE = 1,
		MUST_UPDATE = 2,
		SHOULD_REPLACE = 3,
		SHOULD_DOWNLOAD = 4,
		DOWNLOAD_ERROR = 5,
		UNKNOW_CONN_ERROR = 6,
		SHOULD_UPDATE_RETRY = 7,
		SHOULD_REPLACE_OPTIONAL = 8
	}

	public const int STATE_CONNECTING = 0;

	public const int STATE_DOWNLOADING = 1;

	public int state;

	public STATE infoState;

	public string localVersion;

	public string remoteVersion;

	public string apkUrl;

	public Dictionary<string, string> localIndexDictionary;

	public Dictionary<string, string> remoteIndexDictionary;

	public List<string> Added;

	public List<int> AddedSize;

	public List<string> Removed;

	public int count;

	public int all;

	public long curentKB;

	public long allKB;

	private static VersionUpdateInfo _instance;

	protected VersionUpdateInfo()
	{
	}

	private void Init()
	{
	}

	public long GetAllKB()
	{
		return 0L;
	}

	public static VersionUpdateInfo GetInstance()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void ClearChange()
	{
	}
}
