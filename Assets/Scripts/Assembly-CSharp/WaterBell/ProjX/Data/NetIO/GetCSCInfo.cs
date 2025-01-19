namespace WaterBell.ProjX.Data.NetIO
{
	public class GetCSCInfo : NetMsgBase
	{
		private bool UseClientData;

		public bool useForDebug;

		public GetCSCInfo(bool useClientData = false)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data, bool UseClientData)
		{
		}
	}
}
