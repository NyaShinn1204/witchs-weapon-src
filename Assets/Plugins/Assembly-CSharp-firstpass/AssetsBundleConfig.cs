public class AssetsBundleConfig
{
	public string assetbundlePath;

	public string getResListURL;

	public string getVersionURL;

	public string getAPKURL;

	public string resFileName;

	public string versionFileName;

	public string contentCacheFileName;

	public string loadedCacheFileName;

	public static bool useGhost;

	public string versionDomain;

	public string CDNPath;

	private static AssetsbundleDownloaderCache _cache;

	public string finalMainVer;

	private static AssetsBundleConfig _instance;

	public static string PersistencePath
	{
		get
		{
			return null;
		}
	}

	public string BaseRoot
	{
		get
		{
			return null;
		}
	}

	public string IndexPath
	{
		get
		{
			return null;
		}
	}

	public string IndexFileName
	{
		get
		{
			return null;
		}
	}

	public string VersionPath
	{
		get
		{
			return null;
		}
	}

	public string CacheContentPath
	{
		get
		{
			return null;
		}
	}

	public string CacheLoadedPath
	{
		get
		{
			return null;
		}
	}

	private AssetsBundleConfig()
	{
	}

	private void loadXML()
	{
	}

	public static AssetsBundleConfig Instance()
	{
		return null;
	}

	public string GetCDNURL(string fileMD5)
	{
		return null;
	}

	public static AssetsbundleDownloaderCache GetSharedCache(AssetsBundleConfig conf)
	{
		return null;
	}
}
