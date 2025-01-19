using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using BestHTTP;

public class AssetsbundleDownloader
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDownloadProcess();

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDownloadComplete();

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDownloadError(HTTPRequestStates state, string detail);

	public OnDownloadProcess onProcess;

	public OnDownloadComplete onComplete;

	public OnDownloadError onError;

	private FileStream stream;

	private List<byte[]> cacheBytes;

	private HTTPRequest request;

	private string currentFilePath;

	private int retryCount;

	private string retryURL;

	public AssetsbundleDownloader(AssetsBundleConfig config)
	{
	}

	public void Download(string URL, string filePath)
	{
	}

	public void ReDownload()
	{
	}

	private bool _OnDownloadError(HTTPRequest request)
	{
		return false;
	}

	private void OnDownload(HTTPRequest request, HTTPResponse response)
	{
	}

	private void PauseDownload(HTTPRequest _request, string detail)
	{
	}

	public void DelayCall()
	{
	}
}
