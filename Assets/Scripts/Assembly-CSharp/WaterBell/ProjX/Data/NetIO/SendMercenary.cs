namespace WaterBell.ProjX.Data.NetIO
{
	public class SendMercenary : NetMsgBase
	{
		private string guildid;

		private string svs;

		private string svwps;

		public SendMercenary(string guildid, string svs, string svwps)
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
