namespace WaterBell.ProjX.Data.NetIO
{
	public class CSCDebug : NetMsgBase
	{
		internal string info;

		public CSCDebug(string debugInfo)
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
