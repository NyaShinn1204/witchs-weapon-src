namespace WaterBell.ProjX.Data.NetIO
{
	public class QuitGuild : NetMsgBase
	{
		private string guildid;

		public QuitGuild(string guildid)
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
