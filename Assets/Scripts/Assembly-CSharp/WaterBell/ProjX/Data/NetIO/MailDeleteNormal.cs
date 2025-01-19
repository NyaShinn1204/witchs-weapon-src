namespace WaterBell.ProjX.Data.NetIO
{
	public class MailDeleteNormal : NetMsgBase
	{
		private string mailids;

		public MailDeleteNormal(string mailids)
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
