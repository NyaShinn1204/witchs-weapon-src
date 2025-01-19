using BestHTTP;
using UnityEngine;
using WaterBell.ProjX.Data.NetIO;
using WaterBell.ProjX.View.Panel;

public class NetworkAlertUI
{
	public enum ExceptionMode
	{
		loadIntoMainUI = 0,
		backGroundNoWarning = 1,
		loadIntoBattle = 2,
		sendNormalMsg = 3
	}

	private static GameObject _boxContainer;

	public static void BindDelegate(NetMsgBase msg, ExceptionMode bindMode)
	{
	}

	public static bool CheckIsBlockIngUser()
	{
		return false;
	}

	private static NetworkWatingBoxBase GetBox()
	{
		return null;
	}

	public static void ShowBlockAnima(float Delay = -1f)
	{
	}

	public static void HideBlockAnima()
	{
	}

	public static void ShowConnecting(bool isShow = true)
	{
	}

	public static void ShowRestart(string content = "")
	{
	}

	public static void ShowRestart(string Title, string Content)
	{
	}

	public static void ShowRetry()
	{
	}

	public static void TryShowWarningTipByErrorCode(int code)
	{
	}

	public static void TryShowWarningTipByTag(string tag)
	{
	}

	public static void TryShowWarningTipBox(string tipStr)
	{
	}

	public static void Dispose()
	{
	}

	public static void ShowRestartOnError(string code)
	{
	}

	public static void ShowRestartOnTimeOut(HTTPRequestStates status)
	{
	}

	public static void ShowRestartOnFailed(string detail)
	{
	}

	public static void ShowRetryOnError(int code)
	{
	}

	public static void ShowRetryOnTimeOut(HTTPRequestStates status)
	{
	}

	public static void HandleNormalMsgFailed(string detail)
	{
	}

	public static void RestartGame()
	{
	}

	public static void ShowMsgAlert(string sTitle, string sBtnName, UIAlert.UIAlertInfo[] sInfo, FunctionUnArgs sListener)
	{
	}
}
