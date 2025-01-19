namespace WaterBell.ProjX.Data.NetIO
{
	public class FashionUpdateRune : NetMsgBase
	{
		private string fashionid;

		private string runes;

		public FashionUpdateRune(string fashionid, string runes)
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
