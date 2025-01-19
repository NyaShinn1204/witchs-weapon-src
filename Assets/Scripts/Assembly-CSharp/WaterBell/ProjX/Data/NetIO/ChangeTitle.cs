namespace WaterBell.ProjX.Data.NetIO
{
	public class ChangeTitle : NetMsgBase
	{
		private string title;

		public ChangeTitle(string title)
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
