using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class FileLoader
{
	private AssetBundle _assetBundle;

	private string _cache;

	private bool _isFileCorrupt;

	private AssetBundleCreateRequest _memLoader;

	private WWW _wwwLoader;

	private bool onLoad;

	private void init()
	{
	}

	public static long GetDirectorySize(DirectoryInfo dirInfo)
	{
		return 0L;
	}

	public static string GetDocumentsPath()
	{
		return null;
	}

	public AssetBundle GetAssetBundle()
	{
		return null;
	}

	public byte[] GetByte()
	{
		return null;
	}

	public string GetText()
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator LoadBinary(byte[] data)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator LoadLocal(string path)
	{
		return null;
	}

	public bool isDone()
	{
		return false;
	}

	public bool isError()
	{
		return false;
	}

	public void UnloadFile(bool unloadAllLoadedObjects)
	{
	}

	public void ClearCache()
	{
	}

	public void ClearError()
	{
	}
}
