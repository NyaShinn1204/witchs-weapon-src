namespace WaterBell.ProjX.Data.NetIO
{
	public class MailUpdateSpecialState : NetMsgBase
	{
		private string mailids;

		public MailUpdateSpecialState(string mailids)
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
