using System.Runtime.InteropServices;

namespace Pathfinding.Voxels
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct LinkedVoxelSpan
	{
		public uint bottom;

		public uint top;

		public int next;

		public int area;

		public LinkedVoxelSpan(uint bottom, uint top, int area)
		{
			this.bottom = 0u;
			this.top = 0u;
			next = 0;
			this.area = 0;
		}

		public LinkedVoxelSpan(uint bottom, uint top, int area, int next)
		{
			this.bottom = 0u;
			this.top = 0u;
			this.next = 0;
			this.area = 0;
		}
	}
}
