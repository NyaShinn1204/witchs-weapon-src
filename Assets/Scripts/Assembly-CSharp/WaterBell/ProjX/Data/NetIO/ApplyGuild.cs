namespace WaterBell.ProjX.Data.NetIO
{
	public class ApplyGuild : NetMsgBase
	{
		private string guildid;

		public ApplyGuild(string guildid)
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
