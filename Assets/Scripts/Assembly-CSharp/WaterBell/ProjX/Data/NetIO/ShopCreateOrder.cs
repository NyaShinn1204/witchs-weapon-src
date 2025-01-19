using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ShopCreateOrder : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealCreateOrderResult(string text, string order, string paytype);

		private string setId;

		private string shopId;

		private string goodId;

		private string paytype;

		public dealCreateOrderResult DealResult;

		public ShopCreateOrder(long setId, long shopId, long goodId, int paytype)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
