using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Common.SqliteUtil
{
	[StructLayout(LayoutKind.Sequential, Size = 48)]
	public struct ServantStarAttrTableData
	{
		public long ID;

		public int angle_level;

		public int hp_grow;

		public int physical_attack_grow;

		public int magical_attack_grow;

		public int physical_defense_grow;

		public int magical_defense_grow;

		public int levelup_item_id;

		public int levelup_item_num;

		public int cost;
	}
}
