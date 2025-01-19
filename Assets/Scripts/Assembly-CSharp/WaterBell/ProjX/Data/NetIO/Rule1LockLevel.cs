namespace WaterBell.ProjX.Data.NetIO
{
	public class Rule1LockLevel : NetMsgBase
	{
		private string levelid;

		private string buffid;

		public Rule1LockLevel(string levelid, string buffid)
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
