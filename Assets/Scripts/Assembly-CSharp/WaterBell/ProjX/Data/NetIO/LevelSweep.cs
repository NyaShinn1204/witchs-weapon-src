using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class LevelSweep : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealLevelSweepResult(long id, int count, int exp, int stamina, RepeatedField<Lootmod.LootResult> lootList);

		private string chapid;

		private string instanceid;

		private string count;

		public dealLevelSweepResult DearResult;

		public LevelSweep(string chapid, string instanceid, string count)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		protected override void Init(params string[] names)
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
