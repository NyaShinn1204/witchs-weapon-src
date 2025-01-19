namespace WaterBell.ProjX.Data.NetIO
{
	public class GuildOpenBuff : NetMsgBase
	{
		private string guildid;

		private string buffserial;

		public GuildOpenBuff(string guildid, string buffserial)
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
