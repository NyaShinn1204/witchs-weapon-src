using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class CheckCDKey : NetMsgBase
	{
		private string cdkey;

		public CheckCDKey(string cdkey)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}

		public override void OnInternalError(string detail)
		{
		}
	}
}
