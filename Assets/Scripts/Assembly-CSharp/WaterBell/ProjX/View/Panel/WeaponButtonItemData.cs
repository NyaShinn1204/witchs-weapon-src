using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class WeaponButtonItemData : UIDataBase
	{
		public bool isUnlock;

		public bool isAwake;

		public bool canCompound;

		public bool byCompound;

		public int skinIndex;

		public bool canAwake;

		public long WaponSpellPromoteLv;

		public WeaponButtonItemData(long id, bool isUnlock, bool isAwake, bool canCompound, int skinIndex, bool canAwake = false, long sWaponSpellPromoteLv = 0L)
		{
		}
	}
}
