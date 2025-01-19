using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Common.SqliteUtil
{
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	public struct ServantWeaponAttrTableData
	{
		public long ID;

		public int weapon_attack_modulus;

		public int weapon_spell_level;

		public int min_level;

		public int levelup_gold;

		public int levelup_exp;
	}
}
