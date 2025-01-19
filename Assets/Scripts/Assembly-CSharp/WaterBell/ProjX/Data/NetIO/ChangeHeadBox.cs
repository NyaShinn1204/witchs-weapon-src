namespace WaterBell.ProjX.Data.NetIO
{
	public class ChangeHeadBox : NetMsgBase
	{
		private int headboxid;

		public ChangeHeadBox(int headboxid)
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
