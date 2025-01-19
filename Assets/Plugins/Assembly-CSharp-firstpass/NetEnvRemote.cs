using System.Collections.Generic;
using System.Runtime.InteropServices;
using BestHTTP;

public class NetEnvRemote : NetEnv, IHTTPDetailResponse, IHTTPResponse
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FinishDelegate(int retStatus);

	public const int STAGE_GET_ENV = 1;

	public const int STAGE_GET_MAPPING = 2;

	public const int ERROR_TYPE_NO_NETWORK = 1;

	public const int ERROR_TYPE_NETWORK_OTHER = 2;

	public FinishDelegate OnFinish;

	private int stage;

	private List<Domain> domains;

	private string envURL;

	private string mappingURL;

	public static List<string> versionList;

	public bool CheckNetwrokValid()
	{
		return false;
	}

	public void Init(string channel)
	{
	}

	public void OnData(byte[] bytes, string URL, string type, string tag = null)
	{
	}

	public static string GetLocalVersion()
	{
		return null;
	}

	protected override Domain ParseMapping(string version, string content, List<Domain> domains)
	{
		return null;
	}

	public void OnInternalError(string detail)
	{
	}

	public void OnError(string detail)
	{
	}

	public void OnTimeOut(HTTPRequestStates status)
	{
	}
}
