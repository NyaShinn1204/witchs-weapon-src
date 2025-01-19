namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneDentify : NetMsgBase
	{
		private string rune;

		private string itemdataid;

		public RuneDentify(string rune, string itemdataid)
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
