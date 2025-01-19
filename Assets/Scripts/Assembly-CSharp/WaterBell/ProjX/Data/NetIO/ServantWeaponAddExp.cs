namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantWeaponAddExp : NetMsgBase
	{
		private string servantcardids;

		private string items;

		private string itemnums;

		private string equips;

		private string equipnums;

		public ServantWeaponAddExp(string servantcardids, string items, string itemnums, string equips, string equipnums)
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
