using System.Collections.Generic;

namespace WaterBell.ProjX.Data.NetIO
{
	public class SetData : NetMsgBase
	{
		public List<Mode3LevelModData> levels;

		private int floor;

		private int enemybuff;

		public SetData(List<Mode3LevelModData> lvs, int floor, int enemyBuff)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		private string GetR3Data()
		{
			return null;
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
