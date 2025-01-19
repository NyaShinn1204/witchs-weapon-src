using System.Collections.Generic;
using UnityEngine;
using unit;

public class LogView : MonoBehaviour
{
	private static LogView _instance;

	private static bool isShowInMainUI;

	public bool isShowInUI;

	public bool isSelfEnableButShowNothing;

	public bool isDontDestroy;

	private int viewWidth;

	private int viewHeight;

	private bool isSkipOnGUI;

	private GUIStyle errorTextStyle;

	private GUILayoutOption btnWidth;

	private GUILayoutOption btnHeight;

	private int btnHeightNum;

	private static int cacheMaxLine;

	private static Queue<string> displayLineBuffer;

	private static List<string> fileLineBuffer;

	private string outpath;

	private MonsterEntity currMonster;

	public static string OutLogFullPathAndFileName
	{
		get
		{
			return null;
		}
	}

	public static string UpdateLogFullPathAndFileName
	{
		get
		{
			return null;
		}
	}

	public static void ToggleExistedView()
	{
	}

	public static void TryHideExistedView()
	{
	}

	public static void ToggleInMainUI()
	{
	}

	private static void ShowInMainUI()
	{
	}

	public static void HideInMainUI()
	{
	}

	public static void DeleteOutLog()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}
}
