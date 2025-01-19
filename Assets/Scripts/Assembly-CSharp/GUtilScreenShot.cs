using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class GUtilScreenShot
{
	public class SendErrorScreenAndLogEvent
	{
		public int title;

		public string info;
	}

	public static void SendErrorScreenAndLog(int sTitle, string sInfo)
	{
	}

	private static void ZipErrorData(GUtilListenerEvent sEvent)
	{
	}

	private static void SendErrorData(GUtilListenerEvent sEvent)
	{
	}

	public static void CaptureByUnity(string mFileName)
	{
	}

	[DebuggerHidden]
	public static IEnumerator CaptureByRect(Rect mRect, string mFileName)
	{
		return null;
	}

	[DebuggerHidden]
	public static IEnumerator CaptureByCamera(Camera mCamera, Rect mRect, string mFileName)
	{
		return null;
	}
}
