using System.Runtime.InteropServices;

namespace WaterBell.ProjX.View.Panel
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct ActivityGameDataPropInfo
	{
		public int type;

		public int price;

		public int rate;

		public int value;
	}
}
