namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneLock : NetMsgBase
	{
		private string runeids;

		public RuneLock(string runeids)
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
