namespace WaterBell.ProjX.Data.Entity
{
	public class WeaponExpItemInfo
	{
		public long ID;

		public int Num;

		public int Exp;

		public int NumMax;

		public WeaponExpItemInfo(long ID, int Num, int Exp, int NumMax)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
