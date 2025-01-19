using System.Runtime.InteropServices;

namespace Pathfinding.Voxels
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct VoxelMesh
	{
		public Int3[] verts;

		public int[] tris;
	}
}
