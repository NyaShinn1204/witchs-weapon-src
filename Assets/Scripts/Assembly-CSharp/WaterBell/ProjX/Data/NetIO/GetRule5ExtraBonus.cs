using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetRule5ExtraBonus : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots);

		private string difficult;

		private string isspecial;

		public event dealResult DearResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public GetRule5ExtraBonus(string difficult = "", string isspecial = "")
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
