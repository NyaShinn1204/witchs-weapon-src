using LitJson;
using WaterBell.ProjX.Data.NetIO;

public class UIToolGM : GUtilUISuper
{
	public class GMToolCommand : NetMsgBase
	{
		public GMToolCommand(string cmd, string arg)
		{
		}

		public override void SendMsg()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}

		public override void OnProtoBufData(byte[] bytes)
		{
		}
	}

	private static bool _autoupdate;

	private string preCMD;

	protected override void Start()
	{
	}

	private void initUI()
	{
	}

	private void submitHD()
	{
	}

	private void OnSuccessHD()
	{
	}

	private void OnFailedHD(string sData)
	{
	}

	private string repace(string sData)
	{
		return null;
	}

	private void cmdUpdateData(string sCmd)
	{
	}
}
