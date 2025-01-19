using UnityEngine;

namespace Pathfinding
{
	public class ConvexMeshNode : MeshNode
	{
		private int[] indices;

		protected static INavmeshHolder[] navmeshHolders;

		public ConvexMeshNode(AstarPath astar)
			: base(null)
		{
		}

		static ConvexMeshNode()
		{
		}

		protected static INavmeshHolder GetNavmeshHolder(uint graphIndex)
		{
			return null;
		}

		public void SetPosition(Int3 p)
		{
		}

		public int GetVertexIndex(int i)
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

		public override Vector3 ClosestPointOnNodeXZ(Vector3 p)
		{
			return default(Vector3);
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
		}

		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}
	}
}
