using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ApAccelerateLevelSweep : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealLevelSweepResult(long id, int count, RepeatedField<LootObject> loots);

		private long levelid;

		private int ticketnum;

		public dealLevelSweepResult DearResult;

		public ApAccelerateLevelSweep(long levelid, int ticketnum)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
