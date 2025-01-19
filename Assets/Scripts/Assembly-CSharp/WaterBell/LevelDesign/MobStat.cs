using System.Runtime.InteropServices;

namespace WaterBell.LevelDesign
{
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	public struct MobStat
	{
		public long normalFactorID;

		public long eliteFactorID;

		public long bossFactorID;

		public float[] attrs;
	}
}
