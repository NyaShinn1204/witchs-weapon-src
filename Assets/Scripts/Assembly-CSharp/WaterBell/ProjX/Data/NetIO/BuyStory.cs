using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class BuyStory : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DealResult(int result, RepeatedField<LootObject> loots);

		private string storyid;

		private bool isBuy;

		private long actID;

		private DealResult dealResult;

		public DealResult DealBuyStoryResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BuyStory(string sID)
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
