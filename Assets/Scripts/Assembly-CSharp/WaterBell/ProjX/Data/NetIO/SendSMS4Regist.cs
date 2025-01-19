using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class SendSMS4Regist : NetMsgBase
	{
		private string mobile;

		public SendSMS4Regist(string mobile)
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
