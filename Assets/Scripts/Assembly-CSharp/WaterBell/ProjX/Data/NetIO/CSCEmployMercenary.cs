namespace WaterBell.ProjX.Data.NetIO
{
	public class CSCEmployMercenary : NetMsgBase
	{
		private string mercenaryownerid;

		private string mercenarysvcardids;

		private string garrisonTime;

		public CSCEmployMercenary(string mercenaryownerid, string mercenarysvcardids, string garrisonTime)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
