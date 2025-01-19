using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class LoginBySMS : NetMsgBase
	{
		private string account;

		private string sms;

		public LoginBySMS(string account, string sms)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}
	}
}
