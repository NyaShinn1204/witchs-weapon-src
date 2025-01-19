namespace WaterBell.ProjX.Data.NetIO
{
	public class ChangeBordSvAction : NetMsgBase
	{
		private string bordid;

		public ChangeBordSvAction(string bordid)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
