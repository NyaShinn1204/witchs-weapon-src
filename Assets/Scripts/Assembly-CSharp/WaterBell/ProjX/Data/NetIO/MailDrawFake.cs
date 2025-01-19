namespace WaterBell.ProjX.Data.NetIO
{
	public class MailDrawFake : NetMsgBase
	{
		private string mailids;

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
