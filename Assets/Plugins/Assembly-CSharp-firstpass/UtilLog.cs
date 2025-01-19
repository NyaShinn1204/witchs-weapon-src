using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class UtilLog : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionLog(object sObj);

	private class UIScreenLogInfo
	{
		public string myValue;

		public string myStackTrace;

		public int myType;

		public UIScreenLogInfo(string sValue, string sStackTrace, int sType)
		{
		}
	}

	public static FunctionLog Log;

	public static FunctionLog LogError;

	public static FunctionLog LogWarning;

	private static UtilLog _logView;

	public static bool isLogStackTrace;

	public static bool isLogOpen;

	public static bool isOutFile;

	private static List<UIScreenLogInfo> _logs;

	private Vector2 postion;

	public static bool isLogView
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void clear()
	{
	}

	private static void myLog(object sObj)
	{
	}

	private static void myLogError(object sObj)
	{
	}

	private static void myLogWarning(object sObj)
	{
	}

	private static void logSub()
	{
	}

	public void destroy()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}
}
