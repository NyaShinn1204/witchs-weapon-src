using System.Runtime.InteropServices;
using BestHTTP;

public class AssetsbundleDownloadProcesser
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDownloadError(HTTPRequestStates state, string detail);

	public OnDownloadError onDownloadErr;

	private AssetsbundleDownloader downloader;

	private AssetsbundleDownloaderCache cache;

	private AssetsBundleConfig conf;

	private VersionUpdateInfo versionUpdateInfo;

	private string currentFilePath;

	private string currentMD5;

	private AssetsBundle parent;

	public AssetsbundleDownloadProcesser(AssetsBundleConfig conf, AssetsBundle parent)
	{
	}

	public void DownloadNext(VersionUpdateInfo versionUpdateInfo)
	{
	}

	public void ReDownload()
	{
	}

	private void onDownloadProcess()
	{
	}

	private void onDownloadComplete()
	{
	}

	private void onDownloadError(HTTPRequestStates state, string detail)
	{
	}

	private void WriteDownloadedInfo(string md5, string path)
	{
	}
}
