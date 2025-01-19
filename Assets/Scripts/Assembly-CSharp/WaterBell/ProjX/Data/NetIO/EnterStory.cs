namespace WaterBell.ProjX.Data.NetIO
{
	public class EnterStory : NetMsgBase
	{
		private string instanceid;

		public EnterStory(string instanceid)
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
