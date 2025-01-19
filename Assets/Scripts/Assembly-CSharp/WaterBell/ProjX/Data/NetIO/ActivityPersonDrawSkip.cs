namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityPersonDrawSkip : NetMsgBase
	{
		private long _ID;

		public ActivityPersonDrawSkip(long sID)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
