using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetCscLoot : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(RepeatedField<LootObject> loots);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealBattleResult(Lootmod.LootResult re);

		public dealResult DealGetCscLootResult;

		public dealBattleResult DealGetCscBattleLootResult;

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
