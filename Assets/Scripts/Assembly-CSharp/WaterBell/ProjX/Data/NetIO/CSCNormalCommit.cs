using System.Runtime.InteropServices;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class CSCNormalCommit : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealBattleResult(Lootmod.LootResult re);

		private string paramHP;

		private string paramData;

		private string paramState;

		private string paramSvcardids;

		private string paramEnergys;

		private string fashioncardid;

		private string levelid;

		public static dealBattleResult DealGetCscBattleLootResult;

		public CSCNormalCommit(string levelid, float hp, string data, int state, long[] svcardids, float[] energys)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
