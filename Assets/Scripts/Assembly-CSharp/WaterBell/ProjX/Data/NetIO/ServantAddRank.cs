namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantAddRank : NetMsgBase
	{
		private string servantcardids;

		public ServantAddRank(string servantcardids)
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
