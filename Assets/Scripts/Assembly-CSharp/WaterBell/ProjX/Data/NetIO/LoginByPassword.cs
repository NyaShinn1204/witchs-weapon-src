using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class LoginByPassword : NetMsgBase
	{
		private string account;

		private string pass;

		private string usertype;

		public LoginByPassword(string account, string pass, string usertype)
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
