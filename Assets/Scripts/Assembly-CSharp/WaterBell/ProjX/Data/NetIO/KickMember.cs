namespace WaterBell.ProjX.Data.NetIO
{
	public class KickMember : NetMsgBase
	{
		private string guildid;

		private string target;

		public KickMember(string guildid, string target)
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
