namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantComposeEquip : NetMsgBase
	{
		private string servantcardids;

		private string equips;

		public ServantComposeEquip(string servantcardids, string equips)
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
