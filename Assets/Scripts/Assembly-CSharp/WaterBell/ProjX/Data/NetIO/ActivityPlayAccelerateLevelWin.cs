namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityPlayAccelerateLevelWin : NetMsgBase
	{
		private string floor;

		private string mode;

		private string levelid;

		public ActivityPlayAccelerateLevelWin(string levelid)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
