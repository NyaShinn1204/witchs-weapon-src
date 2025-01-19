namespace WaterBell.ProjX.Data.NetIO
{
	public class PushChallengeProgress : NetMsgBase
	{
		public override string offlineValue
		{
			get
			{
				return null;
			}
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
