namespace WaterBell.ProjX.Data.NetIO
{
	public class MailUpdateCommonState : NetMsgBase
	{
		private string mailids;

		public MailUpdateCommonState(string mailids)
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
