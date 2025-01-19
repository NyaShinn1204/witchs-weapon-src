namespace WaterBell.ProjX.Data.NetIO
{
	public class ChangeHead : NetMsgBase
	{
		private int headid;

		public ChangeHead(int headid)
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
