namespace WaterBell.ProjX.Data.NetIO
{
	public class MirrorLoad : NetMsgBase
	{
		private bool isPublic;

		private long mirrorRID;

		public MirrorLoad(long savedMirrorRoleID)
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
