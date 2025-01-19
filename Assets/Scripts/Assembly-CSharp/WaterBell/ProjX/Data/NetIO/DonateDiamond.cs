namespace WaterBell.ProjX.Data.NetIO
{
	public class DonateDiamond : NetMsgBase
	{
		private string guildid;

		public DonateDiamond(string guildid)
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
