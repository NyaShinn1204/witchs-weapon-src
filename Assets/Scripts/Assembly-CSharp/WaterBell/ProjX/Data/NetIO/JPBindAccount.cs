using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class JPBindAccount : NetMsgBase
	{
		private string uid;

		private string useraccount;

		private string usertype;

		private string password;

		public JPBindAccount(string uid, string useraccount, string usertype)
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
