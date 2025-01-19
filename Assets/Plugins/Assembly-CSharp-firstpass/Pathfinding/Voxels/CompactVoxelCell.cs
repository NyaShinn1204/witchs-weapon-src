using System.Runtime.InteropServices;

namespace Pathfinding.Voxels
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct CompactVoxelCell
	{
		public uint index;

		public uint count;

		public CompactVoxelCell(uint i, uint c)
		{
			index = 0u;
			count = 0u;
		}
	}
}
