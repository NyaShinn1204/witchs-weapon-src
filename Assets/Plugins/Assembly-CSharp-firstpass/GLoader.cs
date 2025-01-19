using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GLoader : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionIDSign(uint sIDSign);

	private static GameObject _instance;

	private static uint _IDSign;

	private static Dictionary<string, WWW> _loadWWWArr;

	private static Dictionary<string, AssetBundle> _loadAssetBundleArr;

	private static Dictionary<string, Object> _loadAssetObjectArr;

	private static Dictionary<string, int> _loadTimes;

	private static Dictionary<string, Object> _hashObjectArr;

	private static Dictionary<string, ResourceRequest> _loadAssetRes;

	private static List<GLoaderData> _loadDataArr;

	private static GLoaderData _loadDataNow;

	private static AssetBundleManifest _manifest;

	private static string _mainAsset;

	private static Dictionary<string, bool> _isUrlIner;

	public static uint IDSign
	{
		get
		{
			return 0u;
		}
	}

	private static AssetBundleManifest manifest
	{
		get
		{
			return null;
		}
	}

	public static string streamingAssetsPath
	{
		get
		{
			return null;
		}
	}

	public static float progress
	{
		get
		{
			return 0f;
		}
	}

	public static int loadingNum
	{
		get
		{
			return 0;
		}
	}

	public static void init()
	{
	}

	private static uint load(FunctionIDSign sListener, string sFullUrl, params string[] sFullUrlArr)
	{
		return 0u;
	}

	private static uint load(List<string> sFullUrlArr, FunctionIDSign sListener)
	{
		return 0u;
	}

	public static T getObject<T>(string sFullUrl, string sName) where T : Object
	{
		return null;
	}

	public static T getObject<T>(string sFullUrl) where T : Object
	{
		return null;
	}

	public static Texture2D getTexture2D(string sFullUrl)
	{
		return null;
	}

	public static bool isHasAsset(string sFullUrl)
	{
		return false;
	}

	private static T getWWWAssetBundle<T>(string sFullUrl, string sName = "mainAsset") where T : Object
	{
		return null;
	}

	public static void ReloadManifest()
	{
	}

	public static void loadAssetBundle(string sFullUrl)
	{
	}

	private static void addTimes(string sFullUrl)
	{
	}

	private static bool subTimesValue0(string sFullUrl)
	{
		return false;
	}

	private static bool timesValue0(string sFullUrl)
	{
		return false;
	}

	private static T getAssetBundle<T>(string sFullUrl, string sName = "mainAsset") where T : Object
	{
		return null;
	}

	public static void Unload(string sFullUrl, bool sIsUnloadAll = true)
	{
	}

	private static void removeAsset(string sFullUrl, bool sIsUnloadAll = true)
	{
	}

	public static void UnloadDependencies(string sFullUrl)
	{
	}

	public static void UnloadAll()
	{
	}

	private void Update()
	{
	}

	private void eventLoadFind()
	{
	}

	private void eventLoad()
	{
	}

	private static bool isUrlIner(string sUrl)
	{
		return false;
	}
}
