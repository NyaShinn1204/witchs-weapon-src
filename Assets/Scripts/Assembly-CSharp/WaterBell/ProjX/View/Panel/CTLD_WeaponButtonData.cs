namespace WaterBell.ProjX.View.Panel
{
	public class CTLD_WeaponButtonData : WeaponButtonItemData
	{
		public int debrisNum;

		public int limtNum;

		public CTLD_WeaponButtonData(long id, bool isUnlock, bool isAwake, bool canCompound, int skinIndex)
			: base(0L, false, false, false, 0, false, 0L)
		{
		}
	}
}
