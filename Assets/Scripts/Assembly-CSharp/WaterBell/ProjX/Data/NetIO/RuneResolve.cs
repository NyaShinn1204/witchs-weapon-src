namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneResolve : NetMsgBase
	{
		private string runeids;

		public RuneResolve(string runeids)
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
