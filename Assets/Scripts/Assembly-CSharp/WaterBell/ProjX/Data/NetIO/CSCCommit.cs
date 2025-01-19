namespace WaterBell.ProjX.Data.NetIO
{
	public class CSCCommit : NetMsgBase
	{
		private string paramHP;

		private string paramData;

		private string paramState;

		private string paramSvcardids;

		private string paramEnergys;

		public CSCCommit(float hp, string data, int state, long[] svcardids, float[] energys)
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
