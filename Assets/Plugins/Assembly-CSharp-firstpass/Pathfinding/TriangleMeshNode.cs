using System.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	public class TriangleMeshNode : MeshNode
	{
		public int v0;

		public int v1;

		public int v2;

		protected static INavmeshHolder[] _navmeshHolders;

		public TriangleMeshNode(AstarPath astar)
			: base(null)
		{
		}

		public static INavmeshHolder GetNavmeshHolder(uint graphIndex)
		{
			return null;
		}

		public static void SetNavmeshHolder(int graphIndex, INavmeshHolder graph)
		{
		}

		public void UpdatePositionFromVertices()
		{
		}

		public int GetVertexIndex(int i)
		{
			return 0;
		}

		public int GetVertexArrayIndex(int i)
		{
			return 0;
		}

		public override Int3 GetVertex(int i)
		{
			return default(Int3);
		}

		public override int GetVertexCount()
		{
			return 0;
		}

		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default(Vector3);
		}

		public override Vector3 ClosestPointOnNodeXZ(Vector3 _p)
		{
			return default(Vector3);
		}

		public override bool ContainsPoint(Int3 p)
		{
			return false;
		}

		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public int SharedEdge(GraphNode other)
		{
			return 0;
		}

		public override bool GetPortal(GraphNode _other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return false;
		}

		public bool GetPortal(GraphNode _other, List<Vector3> left, List<Vector3> right, bool backwards, out int aIndex, out int bIndex)
		{
			aIndex = default(int);
			bIndex = default(int);
			return false;
		}

		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}
	}
}
