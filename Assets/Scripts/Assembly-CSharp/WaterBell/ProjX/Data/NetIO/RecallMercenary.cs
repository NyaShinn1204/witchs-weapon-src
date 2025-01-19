namespace WaterBell.ProjX.Data.NetIO
{
	public class RecallMercenary : NetMsgBase
	{
		private string guildid;

		private string sv;

		public RecallMercenary(string guildid, string sv)
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
