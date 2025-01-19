using System.Collections.Generic;
using System.Runtime.InteropServices;
using BestHTTP;

public class VersionComparator : IHTTPDetailResponse, IHTTPResponse
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnVersionCompareComplete(VersionUpdateInfo.STATE infoState, string apkURL = null);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnVersionCompareError();

	public const string flagFileOfPCCOmplete = "_pc_install_complete.flag";

	public const int EQUALS = 1;

	public const int MORETHEN = 2;

	public const int LESSTHEN = 3;

	public OnVersionCompareComplete OnReady;

	public OnVersionCompareError OnNetError;

	private AssetsBundleConfig conf;

	private bool isVerReady;

	public VersionComparator(AssetsBundleConfig config)
	{
	}

	public bool IsVersionReady()
	{
		return false;
	}

	public void OnData(byte[] bytes, string URL, string type, string tag = null)
	{
	}

	public string GetLocalVersion()
	{
		return null;
	}

	public static string __GetLocalVersion__(AssetsBundleConfig conf)
	{
		return null;
	}

	private string GetRemoteVersion()
	{
		return null;
	}

	public static bool CheckVersionReplace(string version1, string version2, string pref = "")
	{
		return false;
	}

	public string CheckVersionReplaceOptional(string localVersion, List<string> versionList)
	{
		return null;
	}

	public bool HasNewestVersion(string localVersion, string remoteVersion)
	{
		return false;
	}

	public static bool CheckVersionReplaceError(string version1, string version2)
	{
		return false;
	}

	public static bool CheckEqual(string version1, string version2, string pref = "")
	{
		return false;
	}

	public static bool CheckVersionUpdate(string version1, string version2, string pref = "")
	{
		return false;
	}

	private int GetNumByIndex(string version, int index)
	{
		return 0;
	}

	public void CheckVersion()
	{
	}

	public string GetMainVersion(string fullVersion)
	{
		return null;
	}

	public static bool IsPCVersion()
	{
		return false;
	}

	private bool IsFirstInstallComplete()
	{
		return false;
	}

	private bool ShoudForceUpdate()
	{
		return false;
	}

	private void OnVersionReady()
	{
	}

	public void UpdateProcess()
	{
	}

	public int CompareBigVersion(string local, string embed)
	{
		return 0;
	}

	private int CompareMainVersion(int[] local, int[] embed)
	{
		return 0;
	}

	public int CompareSmallVersion(string local, string embed)
	{
		return 0;
	}

	private int CompareResVersion(int local, int embed)
	{
		return 0;
	}

	public void OnInternalError(string detail)
	{
	}

	public void OnError(string detail)
	{
	}

	public void OnTimeOut(HTTPRequestStates status)
	{
	}
}
