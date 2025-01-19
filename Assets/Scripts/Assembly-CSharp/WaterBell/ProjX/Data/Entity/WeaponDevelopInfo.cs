namespace WaterBell.ProjX.Data.Entity
{
	public class WeaponDevelopInfo
	{
		public UseItemArgus useItemArgus;

		public long servantCardID;

		public long weaponInfo;

		public float increasedTotalExp;

		public float WeaponCostFake;

		public int OverFlowExp;

		public int WeaponLevelFake;

		public long WeaponExpFake;

		public int WeaponLevel;

		public long WeaponExp;

		public long WeaponExpLimitFake;

		public int WeaponLevelMax;

		public int WeaponLevelMaxLimitByServantLevel;

		public int WeaponLevelCacheMaxLimitByUserLevel;

		public int OverFlowCostGoldExpMax;

		public int OverFlowExpMax;

		public WeaponDevelopInfo(long servantCardID)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
