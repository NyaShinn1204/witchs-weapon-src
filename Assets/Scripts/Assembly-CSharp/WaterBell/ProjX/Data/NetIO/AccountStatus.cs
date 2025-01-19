using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountStatus : NetMsgBase
	{
		private string account;

		private string usertype;

		public AccountStatus(string account, string usertype)
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
