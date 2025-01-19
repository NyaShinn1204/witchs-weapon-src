namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneDentifyConfirm : NetMsgBase
	{
		private string rune;

		private string itemdataid;

		public RuneDentifyConfirm(string rune, string itemdataid)
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
