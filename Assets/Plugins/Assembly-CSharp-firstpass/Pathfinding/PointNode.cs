using Pathfinding.Serialization;

namespace Pathfinding
{
	public class PointNode : GraphNode
	{
		public GraphNode[] connections;

		public uint[] connectionCosts;

		public PointNode next;

		public PointNode(AstarPath astar)
			: base(null)
		{
		}

		public void SetPosition(Int3 value)
		{
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
		}

		public override void ClearConnections(bool alsoReverse)
		{
		}

		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override bool ContainsConnection(GraphNode node)
		{
			return false;
		}

		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		public override void RemoveConnection(GraphNode node)
		{
		}

		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}
	}
}
