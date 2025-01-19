namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneUnlock : NetMsgBase
	{
		private string runeids;

		public RuneUnlock(string runeids)
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
