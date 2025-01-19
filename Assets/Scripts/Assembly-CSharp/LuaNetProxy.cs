using System.Runtime.InteropServices;
using WaterBell.ProjX.Data.NetIO;

public class LuaNetProxy : NetMsgBase
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDataDelegate(Response reeponses);

	public OnDataDelegate ondata;

	public void AppendKeyValue(string key, string value)
	{
	}

	public override void InitParams(int code)
	{
	}

	public new void SendMsg()
	{
	}

	public void TrySendMsgInBackGround()
	{
	}

	public override void OnProtoBufData(byte[] bytes)
	{
	}

	public void Callback(byte[] data)
	{
	}

	public void CallbackEX(byte[] data)
	{
	}

	public void ShowStamina()
	{
	}
}
