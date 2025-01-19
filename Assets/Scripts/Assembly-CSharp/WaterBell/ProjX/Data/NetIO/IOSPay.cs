using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class IOSPay : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int Result, string TransactionID, RepeatedField<LootObject> lootObjects);

		private string goodsid;

		private string iosdata;

		private string transactionid;

		public dealResult DealResult;

		public IOSPay(string goodId, string iosdata, string transactionid)
		{
		}

		public static void IOSPaySend(IAPUnityHelper.IAPUnityHelperData sData)
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
