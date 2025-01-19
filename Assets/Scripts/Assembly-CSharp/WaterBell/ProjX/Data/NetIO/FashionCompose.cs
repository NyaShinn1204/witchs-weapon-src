namespace WaterBell.ProjX.Data.NetIO
{
	public class FashionCompose : NetMsgBase
	{
		private string fashionid;

		public FashionCompose(string fashionid)
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
