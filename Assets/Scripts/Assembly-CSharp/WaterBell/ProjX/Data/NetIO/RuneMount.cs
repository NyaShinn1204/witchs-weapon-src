namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneMount : NetMsgBase
	{
		private string rune;

		private string servantId;

		private string index;

		public RuneMount(string rune, string servantId, string index)
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
