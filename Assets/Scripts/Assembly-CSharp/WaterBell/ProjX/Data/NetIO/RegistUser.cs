using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class RegistUser : NetMsgBase
	{
		private string account;

		private string pass;

		private string usertype;

		private string cdkey;

		private string SMS;

		public RegistUser(string account, string pass, string usertype, string cdkey, string SMS)
		{
		}

		protected override void AddArgumentsBeforeSend()
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
