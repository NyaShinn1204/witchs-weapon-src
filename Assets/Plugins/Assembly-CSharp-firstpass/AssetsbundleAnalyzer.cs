using System.Collections.Generic;
using System.Runtime.InteropServices;
using BestHTTP;

public class AssetsbundleAnalyzer : IHTTPDetailResponse, IHTTPResponse
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnAnalyzeComplete(VersionUpdateInfo.STATE state);

	private AssetsBundleConfig conf;

	private AssetsbundleDownloaderCache cache;

	private VersionUpdateInfo versionUpdateInfo;

	public OnAnalyzeComplete onComplete;

	public AssetsbundleAnalyzer(AssetsBundleConfig conf)
	{
	}

	public void Sync(string remoteVer)
	{
	}

	private string split(string content)
	{
		return null;
	}

	private void GetRemoteIndex(string remoteVer)
	{
	}

	private Dictionary<string, string> GetLocalIndexDic(string indexPath)
	{
		return null;
	}

	public void OnData(byte[] bytes, string URL, string type, string tag = null)
	{
	}

	private VersionUpdateInfo ToVersion(Dictionary<string, string> remoteIndexDictionary, Dictionary<string, string> localIndexDictionary, AssetsbundleDownloaderCache cache = null)
	{
		return null;
	}

	public static VersionUpdateInfo CheckAdded(Dictionary<string, string> localIndexDictionary, Dictionary<string, string> remoteIndexDictionary)
	{
		return null;
	}

	private void RemoveDeletedFiles(VersionUpdateInfo version)
	{
	}

	private void ResetIndexAndVersion(Dictionary<string, string> remoteIndex, string indexPath, string versionPath, string remoteVersion)
	{
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
