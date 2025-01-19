using System.Collections.Generic;
using BestHTTP;

public class HTTP
{
	public static string HTTP_REQUEST_TYPE_GET;

	public static string HTTP_REQUEST_TYPE_POST;

	private static string HTTPTag;

	public static bool useBestHTTPPro;

	private static Dictionary<HTTPRequest, IHTTPResponse> dic;

	private static Dictionary<HTTPRequest, string> tagDic;

	private static Dictionary<HTTPRequest, int> timeoutDic;

	public static float timeoutTime;

	public static int count;

	public static void GET(string URL, IHTTPResponse response, string tag = null, bool disableCache = false)
	{
	}

	public static void Download(string URL, IHTTPResponse response, string tag = null)
	{
	}

	private static void configRequest(HTTPRequest request)
	{
	}

	private static void OnRequestFinished(HTTPRequest request, HTTPResponse response)
	{
	}

	private static int GetTimeoutCount(HTTPRequest request)
	{
		return 0;
	}

	public static void POST(string URL, Dictionary<string, string> paramDic, IHTTPResponse response, string tag = null)
	{
	}

	public static void POST_NEW(string URL, Dictionary<string, string> paramDic, IHTTPResponse response, string tag = null)
	{
	}

	private static string FullFillURL(string URL)
	{
		return null;
	}
}
