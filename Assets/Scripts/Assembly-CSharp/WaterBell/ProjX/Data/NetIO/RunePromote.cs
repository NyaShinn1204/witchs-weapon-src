namespace WaterBell.ProjX.Data.NetIO
{
	public class RunePromote : NetMsgBase
	{
		private string rune;

		public RunePromote(string rune)
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
