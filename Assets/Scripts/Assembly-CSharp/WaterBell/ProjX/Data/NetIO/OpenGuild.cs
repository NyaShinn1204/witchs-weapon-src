using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class OpenGuild : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots);

		private string jobid;

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

		public OpenGuild(string jobid)
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
