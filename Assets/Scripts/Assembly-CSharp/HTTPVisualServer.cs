using System.Collections.Generic;

public class HTTPVisualServer
{
	private static string fileNamePrefix;

	private static string fileNameExt;

	public string scriptFile;

	private ScriptEngineContext engine;

	private PropertyFile prop;

	public void DoGet(string URL, IHTTPResponse repsonse, string tag)
	{
	}

	private void DispatchHandler(IHTTPResponse response, string URL, string requestType, Dictionary<string, string> dic = null, string tag = "")
	{
	}

	public void DoPost(string URL, Dictionary<string, string> dic, IHTTPResponse resposne, string tag)
	{
	}

	private string DispatchToServlet(string content, Dictionary<string, string> dic, string url, string type)
	{
		return null;
	}
}
