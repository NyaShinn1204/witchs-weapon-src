using System.Collections.Generic;
using UnityEngine;

public class GUtilListener : MonoBehaviour
{
	private static bool _init;

	protected static Dictionary<string, List<GUtilListenerEvent>> _hashListener;

	protected static Dictionary<FunctionListenerEvent, List<GUtilListenerEvent>> _hashEvent;

	protected static Dictionary<double, List<GUtilListenerEvent>> _hashDispatchTime;

	private static uint _signID;

	private static float _time;

	private static string CALL_TIME_HD
	{
		get
		{
			return null;
		}
	}

	public static void reset()
	{
	}

	private static void init()
	{
	}

	public static void addEventListener(string sEventName, FunctionListenerEvent sEvent, object sTarget, bool sIsCareSameListener = true)
	{
	}

	public static void addEventListener(string sEventName, FunctionListenerEvent sEvent)
	{
	}

	public static void dispatch(string sEventName, object sArgs)
	{
	}

	public static void dispatch(string sEventName)
	{
	}

	public static void dispatchTime(string sEventName, float time, object sArgs)
	{
	}

	public static void dispatchTime(string sEventName, float time)
	{
	}

	public static void update()
	{
	}

	public static void removeListener(string sEventName, FunctionListenerEvent sEvent)
	{
	}

	public static void removeListener(string sEventName)
	{
	}

	public static bool hasListener(string sEventName, FunctionListenerEvent sEventFun = null)
	{
		return false;
	}

	public static string calledTime(FunctionListenerEvent sFun, float time, object sTarget, object sArgs)
	{
		return null;
	}

	public static string calledTime(Function sFun, float time)
	{
		return null;
	}

	private static void calledTimdHD(GUtilListenerEvent sEvent)
	{
	}
}
