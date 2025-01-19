using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountModifyPassByCode : NetMsgBase
	{
		private string account;

		private string pass;

		private string ucode;

		public AccountModifyPassByCode(string account, string pass, string ucode)
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
