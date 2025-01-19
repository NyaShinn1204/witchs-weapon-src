namespace WaterBell.ProjX.Data.NetIO
{
	public class MailGetAttach : NetMsgBase
	{
		private string mailids;

		public MailGetAttach(string mailids)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
