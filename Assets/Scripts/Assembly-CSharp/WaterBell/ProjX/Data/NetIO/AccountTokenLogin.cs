using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountTokenLogin : NetMsgBase
	{
		private string account;

		private string token;

		private string usertype;

		private string nickname;

		public AccountTokenLogin(string account, string token, string usertype, string nickname)
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
