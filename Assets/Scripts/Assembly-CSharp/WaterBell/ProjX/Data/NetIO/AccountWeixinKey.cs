using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountWeixinKey : NetMsgBase
	{
		public static string APPID;

		public static string SecureKey;

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}
	}
}
