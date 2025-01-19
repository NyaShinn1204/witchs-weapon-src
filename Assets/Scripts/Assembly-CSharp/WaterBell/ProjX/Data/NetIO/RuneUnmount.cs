namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneUnmount : NetMsgBase
	{
		private string rune;

		private string servantId;

		public RuneUnmount(string rune, string servantId)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public override void InitParams(int code)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
