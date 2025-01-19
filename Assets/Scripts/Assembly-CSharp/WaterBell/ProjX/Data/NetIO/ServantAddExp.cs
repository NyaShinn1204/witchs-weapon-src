namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantAddExp : NetMsgBase
	{
		private string servantcardids;

		private string items;

		private string nums;

		public ServantAddExp(string servantcardids, string items, string nums)
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
