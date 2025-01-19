using System.Collections.Generic;
using UnityEngine;

public class UtilWebViewHelp : MonoBehaviour
{
	private static Dictionary<UniWebView, Function> _listener_close;

	private static HashSet<UniWebView> _hash;

	public static UniWebView ShowWeb(string sUrl, bool sIsOpenIn = true, Function sCloseHD = null)
	{
		return null;
	}

	private static void listenerErrorReceived(UniWebView webView, int errorCode, string errorMessage)
	{
	}

	private static bool listenerOnShouldClose(UniWebView webView)
	{
		return false;
	}

	private static void listenerOnMessageReceived(UniWebView webView, UniWebViewMessage message)
	{
	}

	public static void Clear()
	{
	}
}
