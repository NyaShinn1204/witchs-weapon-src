namespace WaterBell.ProjX.Data.NetIO
{
	internal class SellItemOrEquip : NetMsgBase
	{
		private string items;

		private string itemnums;

		private string equips;

		private string equipnums;

		public SellItemOrEquip(string items, string itemnums, string equips, string equipnums)
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
