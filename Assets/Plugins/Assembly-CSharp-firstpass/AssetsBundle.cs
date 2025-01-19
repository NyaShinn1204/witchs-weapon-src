using BestHTTP;

public class AssetsBundle
{
	private static AssetsBundle _instance;

	private static int _creatingInstanceCounter;

	private INotify notifyHandler;

	private INotifyErr notifyErrHandler;

	private string apkURL;

	public AssetsBundleConfig conf;

	public VersionUpdateInfo updateInfo;

	public VersionComparator comparator;

	public AssetsbundleAnalyzer analyzer;

	public AssetsbundleDownloadProcesser processer;

	private bool _isDirty;

	public bool isFinalVerReady
	{
		get
		{
			return false;
		}
	}

	public float loadPer
	{
		get
		{
			return 0f;
		}
	}

	public float loadNowSize
	{
		get
		{
			return 0f;
		}
	}

	public string LoadNowSizeText
	{
		get
		{
			return null;
		}
	}

	public float loadSize
	{
		get
		{
			return 0f;
		}
	}

	public string LoadSizeText
	{
		get
		{
			return null;
		}
	}

	private AssetsBundle()
	{
	}

	public static void AppendToPrefer(string key, string value)
	{
	}

	public static void DelFromPrefer(string key, string value)
	{
	}

	public static string GetPrefer(string key)
	{
		return null;
	}

	public static AssetsBundle GetInstance()
	{
		return null;
	}

	public void DoExtraInit_IfCDNLoad()
	{
	}

	private void Init()
	{
	}

	private void InitAndResetVersionAndIndex()
	{
	}

	private void InitComparator()
	{
	}

	private void InitAnalyzerAndProcesser()
	{
	}

	private void ResetBaseRoot()
	{
	}

	private void OnVersionsCompareComplete(VersionUpdateInfo.STATE state, string apkURL = null)
	{
	}

	private void OnVersionsCompareError()
	{
	}

	private void OnAnalyzeAllComplete(VersionUpdateInfo.STATE state)
	{
	}

	private void OnDownloadErrorAccr(HTTPRequestStates state, string detail)
	{
	}

	private void processState(VersionUpdateInfo.STATE state)
	{
	}

	public void Retry()
	{
	}

	public void OptionalReplaceDownload()
	{
	}

	public void OptionalReplaceSkip()
	{
	}

	public bool hasNewDownload()
	{
		return false;
	}

	public string GetNewestVersion()
	{
		return null;
	}

	public void StartCheckVersion(INotify notify, INotifyErr notifyErr)
	{
	}

	public string GetAssetsBundle(string path)
	{
		return null;
	}

	public bool isEnough(float size)
	{
		return false;
	}

	public void StarLoad()
	{
	}

	public int LoadState()
	{
		return 0;
	}

	public bool CheckUpdate()
	{
		return false;
	}

	public string GetVersion()
	{
		return null;
	}

	public string GetAPKDownloadURL()
	{
		return null;
	}

	public void ReDownload()
	{
	}

	public void MarkIsDirty()
	{
	}

	public void MarkIsDirtyFalse()
	{
	}

	public bool GetIsDirty()
	{
		return false;
	}

	public void Repair()
	{
	}
}
