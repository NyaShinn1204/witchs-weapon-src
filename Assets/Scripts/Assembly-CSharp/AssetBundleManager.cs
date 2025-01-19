using System;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleManager : MonoBehaviour
{
	public class AssetInfo
	{
		public UnityEngine.Object assetObject;

		public string assetPath;

		public bool isStatic;

		public AssetInfo(string path, UnityEngine.Object obj, bool staticFlag)
		{
		}
	}

	public enum BundleState
	{
		NotFound = 0,
		FileExists = 1,
		FileOutOfDate = 2,
		Loading = 3,
		OnList = 4
	}

	public enum ePriority
	{
		Low = 0,
		Normal = 1,
		High = 2
	}

	public enum ErrorHandleMode
	{
		Default = 0,
		QueryRetry = 1,
		TutorialForceRetry = 1,
		ForceIgnore = 2
	}

	public class LoadInfo
	{
		public string fileName;

		public string filePath;

		public Type fileType;

		public bool ignoreError;

		public bool isStatic;

		public bool onDownload;

		public ePriority priority;

		public bool reqDownloadOnly;

		public bool reqRelease;

		public int wwwHandle;

		public LoadInfo(LoadInfo src)
		{
		}

		public LoadInfo(Type type, string path, string name, ePriority priority, bool staticFlag, bool ignoreErr = false)
		{
		}
	}

	public class LoadUnit
	{
		public FileLoader loader;

		public LoadInfo loadInfo;
	}

	private static AssetBundleManager _instance;

	private ErrorHandleMode _downloadErrorHandleMode;

	private const string _dummyTextureName = "";

	private string _errorName;

	private int _idleCtr;

	private List<LoadInfo> _loadQueue;

	private LoadUnit[] _loadUnit;

	private List<AssetInfo> _objectList;

	private List<LoadInfo> _retryQueue;

	private bool _showProgress;

	private int _unitNum;

	public static readonly string BundlePath;

	public static readonly string BundleExt;

	public static AssetBundleManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public UnityEngine.Object GetObject(Type type, string name, string path)
	{
		return null;
	}

	private UnityEngine.Object _GetObject(Type type, string name, string path)
	{
		return null;
	}

	public BundleState GetStatus(Type type, string name, string path)
	{
		return default(BundleState);
	}

	private void Enqueue(LoadInfo info)
	{
	}

	private void EnqueueWithoutCheck(LoadInfo info)
	{
	}

	private LoadInfo Dequeue()
	{
		return null;
	}

	private bool CheckDequeue()
	{
		return false;
	}

	private void checkErrorRetry(bool doRetry, LoadInfo info)
	{
	}

	public void CancelRequestAll()
	{
	}

	public void DeleteBundle(string path)
	{
	}

	public void DownloadRequest(Type type, string path, string name, ePriority pri, bool ignoreErr = false)
	{
	}

	public int GetLoadRequestNum()
	{
		return 0;
	}

	public bool IsBundleExist(string path)
	{
		return false;
	}

	private bool IsInDownLoading(LoadInfo info)
	{
		return false;
	}

	private bool IsLoadingObject(Type type, string name, string path, bool checkDownload)
	{
		return false;
	}

	private void ExecLoadUnit(LoadUnit unit)
	{
	}

	public static void Assert(bool condition, string msg)
	{
	}
}
