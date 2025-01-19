namespace WaterBell.ProjX.Data.NetIO
{
	public class PushGuideStoryProgress : NetMsgBase
	{
		private bool isWin;

		private int starNum;

		public PushGuideStoryProgress(bool isWin)
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
