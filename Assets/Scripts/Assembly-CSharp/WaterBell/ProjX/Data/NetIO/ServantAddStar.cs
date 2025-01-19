namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantAddStar : NetMsgBase
	{
		private string servantcardids;

		public ServantAddStar(string servantcardids)
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
