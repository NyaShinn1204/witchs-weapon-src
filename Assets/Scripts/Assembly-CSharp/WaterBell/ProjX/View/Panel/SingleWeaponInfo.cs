using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class SingleWeaponInfo : UIDataBase
	{
		public long servantID;

		public bool canAwake;

		public bool canCompound;

		public long level;

		public long exp;

		public int maxLevel;

		public long expLimit;

		public bool isUnlock;

		public bool isAwake;

		public bool byCompound;

		public int weaponIndex;

		public int awakeNeedRank;

		public long awakeNeedGold;

		public NeedLootInfo composeItem1;

		public NeedLootInfo composeItem2;

		public NeedLootInfo composeItem3;

		public NeedLootInfo awakeItem1;

		public NeedLootInfo awakeItem2;

		public NeedLootInfo awakeItem3;

		public int currentSkinIndex;

		public bool currentSkinUnlock;

		public int skinUnlockStates;

		public float patk;

		public float matk;

		public SingleWeaponInfo(long id, int weaponIndex, CurrentServantWeaponInfoViewModel weaponViewModel)
		{
		}

		public SingleWeaponInfo(long id, int weaponIndex)
		{
		}

		public void Bind(long id, int weaponIndex, CurrentServantWeaponInfoViewModel weaponViewModel)
		{
		}
	}
}
