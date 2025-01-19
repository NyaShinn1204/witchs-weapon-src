using System.Runtime.InteropServices;

namespace WaterBell.LevelDesign
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct MobLvRange
	{
		public int min;

		public int max;
	}
}
