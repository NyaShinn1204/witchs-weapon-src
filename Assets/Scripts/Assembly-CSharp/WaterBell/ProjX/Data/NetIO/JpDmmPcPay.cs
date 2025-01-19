using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class JpDmmPcPay : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int Result, string TransactionID, RepeatedField<LootObject> lootObjects);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealOrderCheckResult(int Result, string goodid, string TransactionID, RepeatedField<LootObject> lootObjects);

		private string goodsid;

		private string dmm_data;

		private string dmm_signature;

		private string productId;

		private string transactionid;

		public dealResult DealResult;

		public dealOrderCheckResult DealOrderCheckResult;

		public JpDmmPcPay(string goodsid, string dmm_data, string dmm_signature, string productId, string transactionid)
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
