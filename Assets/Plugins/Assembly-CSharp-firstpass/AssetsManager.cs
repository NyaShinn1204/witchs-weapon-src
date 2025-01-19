using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class AssetsManager
{
	public enum AssetsType
	{
		UnCare = 1,
		UIPrefab = 2,
		Effect = 3,
		Mob = 4,
		Atlas = 5,
		WaitCall = 6,
		Audio = 7,
		Guide = 8,
		Temp_1 = 1000,
		Temp_Mail = 1001,
		Temp_UserSetting = 1002,
		Temp_Achievement = 1003,
		Temp_Task = 1004,
		Temp_Lottery = 1005,
		Temp_Telphone = 1006,
		Temp_NewShopPanel = 1007,
		Temp_PackageRework = 1008,
		Temp_ServantListRework = 1009,
		Temp_ServantDisplayGesturePanel = 1010,
		Temp_SelectLevelDetail = 1011,
		Temp_VipPanel = 1012,
		Temp_PlotReview = 1013,
		Temp_ActivityGamePanel = 1014,
		Temp_ActivePlayModePanel = 1015,
		Temp_ActiveMateriaPanel = 1016,
		Temp_HelpPanelControl = 1017,
		Temp_GetWeaponAndSvPanel = 1018,
		Temp_QuickDrawPanel = 1019,
		Temp_GetAwardsPanel = 1020,
		Temp_LoadingTipsPanel = 1021,
		Temp_UnlockNotificationPanel = 1022,
		Temp_ChapterLevelUpPanel = 1023,
		Temp_SweepPanel = 1024,
		Temp_SmartWatch = 1025,
		Temp_GetServantImagePanel = 1026,
		Temp_LotteryUniverseUIscene = 1027,
		Temp_TrialPanel = 5000,
		Temp_ClimbPanel = 5001,
		Temp_Expedition = 5002,
		Temp_TrainingPanelControl = 5003,
		Temp_MoneyGameControll = 5004,
		Temp_Acitve = 5005,
		LuaAssets1 = 5006,
		LuaAssets2 = 5007,
		LuaAssets3 = 5008,
		LuaAssets4 = 5009,
		LuaAssets5 = 5010,
		LuaAssets6 = 5011,
		LuaAssets7 = 5012,
		LuaAssets8 = 5013,
		LuaAssets9 = 5014,
		LuaAssets10 = 5015,
		LuaAssets11 = 5016,
		LuaAssets12 = 5017,
		LuaAssets13 = 5018
	}

	private static int _isMemoryUnloadOnClose;

	private static string _PREFS_IS_MERMORY_UNLOSD_ONCLOSE;

	private static Dictionary<AssetsType, List<string>> _hashUnload;

	private static Dictionary<string, AssetsType> _hashUnloadKEY;

	private static UIAtlas m_mainAtlas;

	private static UIAtlas m_battleAtlas;

	private static List<string> _scene;

	private static string _currentScene;

	public static bool isMemoryUnloadOnClose
	{
		get
		{
			return false;
		}
	}

	public static UIAtlas mainAtlas
	{
		get
		{
			return null;
		}
	}

	public static UIAtlas battleAtlas
	{
		get
		{
			return null;
		}
	}

	public static AudioClip loadAudio(string resourceName)
	{
		return null;
	}

	private static string[] GetRealAssetBundleName(string locate)
	{
		return null;
	}

	public static T LoadResources<T>(string locate, AssetsType sType) where T : Object
	{
		return null;
	}

	public static Font LoadFont(string sFontName)
	{
		return null;
	}

	public static GameObject LoadResourceForLua(string locate)
	{
		return null;
	}

	public static GameObject LoadResourceForLua(string locate, AssetsType assetsType)
	{
		return null;
	}

	public static Texture LoadTextureForLua(string locate)
	{
		return null;
	}

	public static Texture LoadTextureForLua(string locate, AssetsType assetsType)
	{
		return null;
	}

	public static Texture LoadTextureForLuaEx(string locate, AssetsType assetsType)
	{
		return null;
	}

	public static UIAtlas LoadUIAtlas(string locate, AssetsType assetsType)
	{
		return null;
	}

	public static GameObject LoadResources(string locate, AssetsType sType)
	{
		return null;
	}

	public static Texture LoadTexture(string locate, AssetsType assetsType)
	{
		return null;
	}

	public static GameObject LoadAndInstantiate(string locate, AssetsType sType)
	{
		return null;
	}

	private static int isStreamingAsset(string sUrl)
	{
		return 0;
	}

	public static void LoadScene(string sSenceName, LoadSceneMode sMode = LoadSceneMode.Single)
	{
	}

	public static AsyncOperation LoadSceneAsync(string sSenceName, LoadSceneMode sMode = LoadSceneMode.Single)
	{
		return null;
	}

	public static void UnloadScene()
	{
	}

	public static void UnloadByPath(string sPath)
	{
	}

	public static string LoadText(string sPath)
	{
		return null;
	}

	public static byte[] LoadBytesLua(string sPath)
	{
		return null;
	}

	public static StreamReader LoadStreamReader(string sPath)
	{
		return null;
	}

	public static byte[] byteEncrypt(byte[] sData)
	{
		return null;
	}

	public static void UnloadCache()
	{
	}

	public static void UnloadType(AssetsType sType, bool sIsGC = true)
	{
	}

	public static void UnloadCacheWaitCall()
	{
	}
}
