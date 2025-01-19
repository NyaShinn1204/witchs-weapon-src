namespace WaterBell.ProjX.Data.NetIO
{
	public class ReceiveSVImageReward : NetMsgBase
	{
		private string servantcardids;

		private string serial;

		public ReceiveSVImageReward(string servantcardids, string serial)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
