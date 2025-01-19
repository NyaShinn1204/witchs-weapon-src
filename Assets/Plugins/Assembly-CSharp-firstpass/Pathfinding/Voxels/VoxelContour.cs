using System.Runtime.InteropServices;

namespace Pathfinding.Voxels
{
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	public struct VoxelContour
	{
		public int nverts;

		public int[] verts;

		public int[] rverts;

		public int reg;

		public int area;
	}
}
