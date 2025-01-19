using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class BindPhoneEmail : NetMsgBase
	{
		private string uid;

		private string useraccount;

		private string usertype;

		private string password;

		public BindPhoneEmail(string uid, string useraccount, string usertype, string password)
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
