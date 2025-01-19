using System.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	public abstract class MeshNode : GraphNode
	{
		public GraphNode[] connections;

		public uint[] connectionCosts;

		public MeshNode(AstarPath astar)
			: base(null)
		{
		}

		public abstract Int3 GetVertex(int i);

		public abstract int GetVertexCount();

		public abstract Vector3 ClosestPointOnNode(Vector3 p);

		public abstract Vector3 ClosestPointOnNodeXZ(Vector3 p);

		public override void ClearConnections(bool alsoReverse)
		{
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
		}

		public override void FloodFill(Stack<GraphNode> stack, uint region)
		{
		}

		public override bool ContainsConnection(GraphNode node)
		{
			return false;
		}

		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		public override void RemoveConnection(GraphNode node)
		{
		}

		public virtual bool ContainsPoint(Int3 p)
		{
			return false;
		}

		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}
	}
}
