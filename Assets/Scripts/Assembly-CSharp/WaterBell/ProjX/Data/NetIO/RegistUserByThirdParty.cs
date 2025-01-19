using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class RegistUserByThirdParty : NetMsgBase
	{
		private string account;

		private string usertype;

		private string nickName;

		private string efunsign;

		private string dmm_signature;

		private string ios_token;

		public RegistUserByThirdParty(string account, string usertype, string nickName, string efunsign = "", string dmm_signature = "", string ios_token = "")
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public void AddArgumentsForTW(string sign, string game, string channel)
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}
	}
}
