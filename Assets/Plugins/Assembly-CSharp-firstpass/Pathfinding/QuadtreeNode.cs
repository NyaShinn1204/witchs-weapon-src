namespace Pathfinding
{
	public class QuadtreeNode : GraphNode
	{
		public GraphNode[] connections;

		public uint[] connectionCosts;

		public QuadtreeNode(AstarPath astar)
			: base(null)
		{
		}

		public void SetPosition(Int3 value)
		{
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
		}

		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		public override void RemoveConnection(GraphNode node)
		{
		}

		public override void ClearConnections(bool alsoReverse)
		{
		}

		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}
	}
}
