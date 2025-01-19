namespace WaterBell.ProjX.Data.NetIO
{
	public class MirrorSave : NetMsgBase
	{
		private bool isPublic;

		private long tgtMirrorID;

		public MirrorSave(bool isPublic, long targetmirrorID)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static bool ParseProtoBuf(byte[] data)
		{
			return false;
		}
	}
}
