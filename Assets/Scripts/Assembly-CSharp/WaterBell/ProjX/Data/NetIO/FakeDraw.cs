namespace WaterBell.ProjX.Data.NetIO
{
	public class FakeDraw : NetMsgBase
	{
		private string fakeid;

		public FakeDraw(string fakeid)
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
