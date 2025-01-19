using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ShopCheckPayment : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealCheckPaymentResult(string errorcode, string orderid);

		private string paytype;

		private string orderno;

		private string returncode;

		private string goodsid;

		public dealCheckPaymentResult DealResult;

		public ShopCheckPayment(long paytype, string orderno, long returncode, string goodsid)
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
