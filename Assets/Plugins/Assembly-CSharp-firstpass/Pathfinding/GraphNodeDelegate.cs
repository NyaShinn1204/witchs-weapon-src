using System.Runtime.InteropServices;

namespace Pathfinding
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void GraphNodeDelegate(GraphNode node);
}
