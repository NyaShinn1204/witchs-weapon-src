namespace WaterBell.ProjX.Data.NetIO
{
	public class APAttributeAdd : NetMsgBase
	{
		private string delta;

		public APAttributeAdd(string delta)
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
