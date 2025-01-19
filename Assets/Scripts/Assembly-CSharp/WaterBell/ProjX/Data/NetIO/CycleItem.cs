namespace WaterBell.ProjX.Data.NetIO
{
	public class CycleItem : NetMsgBase
	{
		private string items;

		private string itemnums;

		public CycleItem(string items, string itemnums)
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
