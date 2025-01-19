namespace WaterBell.ProjX.Data.NetIO
{
	public class RecallPresident : NetMsgBase
	{
		private string guildid;

		public RecallPresident(string guildid)
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
