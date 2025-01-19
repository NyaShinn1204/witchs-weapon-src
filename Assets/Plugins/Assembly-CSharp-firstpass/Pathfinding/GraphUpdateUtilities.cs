using System;
using System.Collections.Generic;

namespace Pathfinding
{
	public static class GraphUpdateUtilities
	{
		[Obsolete]
		public static bool IsPathPossible(GraphNode n1, GraphNode n2)
		{
			return false;
		}

		[Obsolete]
		public static bool IsPathPossible(List<GraphNode> nodes)
		{
			return false;
		}

		public static bool UpdateGraphsNoBlock(GraphUpdateObject guo, GraphNode node1, GraphNode node2, bool alwaysRevert = false)
		{
			return false;
		}

		public static bool UpdateGraphsNoBlock(GraphUpdateObject guo, List<GraphNode> nodes, bool alwaysRevert = false)
		{
			return false;
		}
	}
}
