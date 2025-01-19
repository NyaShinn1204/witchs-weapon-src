namespace WaterBell.ProjX.Data.NetIO
{
	internal class UseItem : NetMsgBase
	{
		private string items;

		private string itemnums;

		private string targetItem;

		public UseItem(string items, string itemnums, string targetItem = "")
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
