namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantAddSpell : NetMsgBase
	{
		private string servantcardids;

		private string spelltype;

		public ServantAddSpell(string servantcardids, string spelltype)
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
