using System.Runtime.InteropServices;

namespace WaterBell.ProjX.View.Panel
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct ForgeNeedNum
	{
		public long id;

		public int needNum;

		public ForgeNeedNum(long id, int needNum)
		{
			this.id = 0L;
			this.needNum = 0;
		}
	}
}
