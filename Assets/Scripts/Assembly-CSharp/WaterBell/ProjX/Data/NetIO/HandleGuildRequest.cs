namespace WaterBell.ProjX.Data.NetIO
{
	public class HandleGuildRequest : NetMsgBase
	{
		private string guildid;

		private string targetid;

		private string allow;

		public HandleGuildRequest(string guildid, string targetid, string allow)
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
