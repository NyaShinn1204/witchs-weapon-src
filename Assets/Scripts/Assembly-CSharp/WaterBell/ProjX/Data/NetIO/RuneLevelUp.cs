namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneLevelUp : NetMsgBase
	{
		private string runeid;

		private string runeids;

		public RuneLevelUp(string runeid, string runeids)
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
