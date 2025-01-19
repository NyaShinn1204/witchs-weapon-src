namespace WaterBell.ProjX.Data.NetIO
{
	public class PushStoryLineProgress : NetMsgBase
	{
		private bool isWin;

		private int starNum;

		private long combatscore;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public PushStoryLineProgress(bool isWin, int starNum, long combatscore)
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
