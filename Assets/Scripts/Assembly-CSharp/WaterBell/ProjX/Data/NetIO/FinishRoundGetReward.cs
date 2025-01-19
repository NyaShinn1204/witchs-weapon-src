using System.Runtime.InteropServices;
using Actionmod;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class FinishRoundGetReward : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots, ExtraInfo ExtraInfo, int mode, string difficult = "", bool isspecial = false);

		private string floor;

		private int mode;

		private string levelid;

		private bool isspecial;

		private string difficult;

		public event dealResult DearResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public FinishRoundGetReward(int floor, int mode, long levelID, string difficult = "", bool isspecial = false)
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
