using System.Collections.Generic;
using UnityEngine;

public class GUtilAssetsCut : MonoBehaviour
{
	public class Info
	{
		public string key;

		public string path;

		public bool uncare;

		public int size;

		public string md5;
	}

	private static bool _init;

	private static HashSet<string> _hashCut;

	private static Dictionary<string, List<Info>> _hashCutData;

	private static void Init()
	{
	}

	public static bool IsCutAssets(string sPathAB)
	{
		return false;
	}

	public static string MathPath2PathAB(string sPath)
	{
		return null;
	}

	private static bool IsHasAsset(string sPath)
	{
		return false;
	}

	public static void AsyncWaitDownLoadAction(string sActionID, FunctionListenerEvent sSucceed, FunctionListenerEvent sCancel, FunctionListenerEvent sFailed, GUtilListenerEvent sEventData, bool sIsAskAction = true)
	{
	}

	private static float MathSize(List<Info> sInfoList)
	{
		return 0f;
	}

	public static List<string> GetAssetsByLessonID(string ID)
	{
		return null;
	}
}
