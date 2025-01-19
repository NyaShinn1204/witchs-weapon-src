using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HTTPRequest : MonoBehaviour
{
	private Dictionary<int, IHTTPResponse> dic;

	public static bool useVisualServer;

	public static string serverId;

	private static HTTPVisualServer server;

	private HTTPVisualServer GetVisualServer()
	{
		return null;
	}

	private void RegisterResponse(IHTTPResponse response)
	{
	}

	public void GET(string URL, IHTTPResponse response, string tag)
	{
	}

	public void POST(string URL, string content, IHTTPResponse response, string tag)
	{
	}

	public void POST(string URL, Dictionary<string, string> keyValues, IHTTPResponse response, string tag)
	{
	}

	[DebuggerHidden]
	private IEnumerator Get(string URL, int key)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Post(string URL, string postContent, Dictionary<string, string> header, int key, string tag)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Post(string URL, WWWForm form, int key, string tag)
	{
		return null;
	}
}
