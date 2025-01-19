using System.Runtime.InteropServices;

namespace WaterBell.LevelDesign
{
	[StructLayout(LayoutKind.Sequential, Size = 20)]
	public struct MobFactor
	{
		public int hpFactorIdx;

		public int atkFactorIdx;

		public int defFactorIdx;

		public float hpMulti;

		public float atkMulti;
	}
}
