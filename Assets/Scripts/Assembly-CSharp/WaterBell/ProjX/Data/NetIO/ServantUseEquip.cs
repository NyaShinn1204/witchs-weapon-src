namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantUseEquip : NetMsgBase
	{
		private string servantcardids;

		private string equipslots;

		public ServantUseEquip(string servantcardids, string equipslots)
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
