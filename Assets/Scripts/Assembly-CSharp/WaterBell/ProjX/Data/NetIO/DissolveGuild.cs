namespace WaterBell.ProjX.Data.NetIO
{
	public class DissolveGuild : NetMsgBase
	{
		private string guildid;

		public DissolveGuild(string guildid)
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
