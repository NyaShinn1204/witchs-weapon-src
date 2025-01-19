namespace WaterBell.ProjX.Data.NetIO
{
	public class CSCSvGroup : NetMsgBase
	{
		private string servantcardids;

		private string mercenaryownerid;

		private string mercenarysvcardids;

		private string garrisonTime;

		public CSCSvGroup(string servantcardids, string mercenaryownerid, string mercenarysvcardids, string garrisonTime)
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
