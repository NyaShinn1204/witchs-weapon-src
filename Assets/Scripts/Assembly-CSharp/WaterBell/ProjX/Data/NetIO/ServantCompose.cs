namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantCompose : NetMsgBase
	{
		private string servantcardids;

		public ServantCompose(string servantcardids)
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
