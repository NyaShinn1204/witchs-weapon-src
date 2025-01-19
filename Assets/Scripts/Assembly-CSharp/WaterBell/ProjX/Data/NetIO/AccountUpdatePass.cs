using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountUpdatePass : NetMsgBase
	{
		private string account;

		private string pass;

		public AccountUpdatePass(string account, string pass)
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
