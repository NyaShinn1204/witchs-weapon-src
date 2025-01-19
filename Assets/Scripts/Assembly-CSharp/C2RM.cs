using System.Runtime.InteropServices;
using BestHTTP;

public class C2RM : IHTTPDetailResponse, IHTTPResponse
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionC2RM(C2RM sC2RM);

	protected int _times;

	protected FunctionC2RM _error;

	protected FunctionC2RM _succeed;

	public int loadTimes
	{
		get
		{
			return 0;
		}
	}

	public C2RM(FunctionC2RM sSucceed, FunctionC2RM sError)
	{
	}

	public virtual void Load()
	{
	}

	public virtual void OnInternalError(string detail)
	{
	}

	public virtual void OnError(string detail)
	{
	}

	public virtual void OnTimeOut(HTTPRequestStates status)
	{
	}

	public virtual void OnData(byte[] bytes, string URL, string type, string tag = null)
	{
	}
}
