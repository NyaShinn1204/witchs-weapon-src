namespace WaterBell.ProjX.Data.NetIO
{
	public class DonateGold : NetMsgBase
	{
		private string guildid;

		public DonateGold(string guildid)
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
