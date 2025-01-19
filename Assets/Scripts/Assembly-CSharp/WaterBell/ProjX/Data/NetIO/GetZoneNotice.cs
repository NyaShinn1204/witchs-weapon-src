using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetZoneNotice : NetMsgBase
	{
		private string zid;

		public GetZoneNotice(string zid)
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
