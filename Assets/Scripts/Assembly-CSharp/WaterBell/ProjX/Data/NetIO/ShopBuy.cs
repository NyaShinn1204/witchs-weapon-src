using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ShopBuy : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(string text, string order, RepeatedField<LootObject> lootObjects);

		private string setId;

		private string shopId;

		private string goodId;

		private string count;

		public dealResult DealResult;

		public ShopBuy(long setId, long shopId, long goodId, int count)
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
