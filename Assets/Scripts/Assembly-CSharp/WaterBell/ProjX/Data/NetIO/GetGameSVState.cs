using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetGameSVState : NetMsgBase
	{
		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		private string getDataAsText(byte[] data)
		{
			return null;
		}
	}
}
