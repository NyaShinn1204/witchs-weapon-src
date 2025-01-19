using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class JpGooglePay : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int Result, string TransactionID, RepeatedField<LootObject> lootObjects);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealOrderCheckResult(int Result, string goodid, string TransactionID, RepeatedField<LootObject> lootObjects);

		private string goodsid;

		private string googledata;

		private string googleorder;

		private string productId;

		public dealResult DealResult;

		public dealOrderCheckResult DealOrderCheckResult;

		public JpGooglePay(string goodsid, string googledata, string googleorder, string productId)
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
