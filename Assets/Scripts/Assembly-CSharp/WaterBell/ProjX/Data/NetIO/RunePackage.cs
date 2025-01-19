namespace WaterBell.ProjX.Data.NetIO
{
	public class RunePackage : NetMsgBase
	{
		private string runes;

		public RunePackage(string runes)
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
