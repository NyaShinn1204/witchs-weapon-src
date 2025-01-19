using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityDrawSpecial : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots);

		private string times;

		private string baseid;

		private dealResult dearResult;

		public dealResult DearResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActivityDrawSpecial(string times, string baseid)
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
