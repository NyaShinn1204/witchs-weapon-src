using System.Runtime.InteropServices;
using BestHTTP;

public class VersionComparator4Login : IHTTPDetailResponse, IHTTPResponse
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnNetComplete(int status);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnNetError();

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnVersionTimeOut();

	public OnNetComplete OnVersionComplete;

	public OnNetError OnVersionError;

	public OnVersionTimeOut OnCheckVersionTimeOut;

	private AssetsBundleConfig conf;

	private string LOG_PREF;

	public void CheckVersion()
	{
	}

	public void OnData(byte[] bytes, string URL, string type, string tag = null)
	{
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
