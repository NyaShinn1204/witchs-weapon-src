using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Common.SqliteUtil
{
	[StructLayout(LayoutKind.Sequential, Size = 224)]
	public struct ServantWeaponTableData
	{
		public long id;

		public long servant_id;

		public long decompose_item_id1;

		public int decompose_item_num1;

		public long decompose_item_id2;

		public int decompose_item_num2;

		public long compose_item_id1;

		public int compose_item_num1;

		public long compose_item_id2;

		public int compose_item_num2;

		public int weapon_rare;

		public string weapon_prefab;

		public long weapon_name;

		public long weapon_desc;

		public long weapon_specific_desc;

		public string weapon_icon;

		public string weapon_item_icon;

		public string weapon_image;

		public int weapon_physical_attack1;

		public int weapon_physical_attack2;

		public int weapon_physical_attack3;

		public int weapon_magical_attack1;

		public int weapon_magical_attack2;

		public int weapon_magical_attack3;

		public long promote1_item1;

		public int promote1_item_num1;

		public long promote1_item2;

		public int promote1_item_num2;

		public long promote2_item1;

		public int promote2_item_num1;

		public long promote2_item2;

		public int promote2_item_num2;
	}
}
