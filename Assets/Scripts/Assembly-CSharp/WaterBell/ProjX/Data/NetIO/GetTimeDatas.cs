namespace WaterBell.ProjX.Data.NetIO
{
	public class GetTimeDatas : NetMsgBase
	{
		private string mailids;

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
