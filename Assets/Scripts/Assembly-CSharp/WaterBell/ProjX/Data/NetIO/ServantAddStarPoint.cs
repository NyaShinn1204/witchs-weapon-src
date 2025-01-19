namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantAddStarPoint : NetMsgBase
	{
		private string servantcardids;

		private string starpointserial;

		public ServantAddStarPoint(string servantcardids, string starpointserial)
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
