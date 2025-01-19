namespace WaterBell.ProjX.Data.NetIO
{
	public class GetAllMercenariesList : NetMsgBase
	{
		public string ResultGuildid;

		private string guildid;

		public GetAllMercenariesList(string guildid)
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
