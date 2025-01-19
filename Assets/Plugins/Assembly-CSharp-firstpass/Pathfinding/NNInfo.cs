using UnityEngine;

namespace Pathfinding
{
	public struct NNInfo
	{
		public GraphNode node;

		public GraphNode constrainedNode;

		public Vector3 clampedPosition;

		public Vector3 constClampedPosition;

		public NNInfo(GraphNode node)
		{
			this.node = null;
			constrainedNode = null;
			clampedPosition = default(Vector3);
			constClampedPosition = default(Vector3);
		}

		public void SetConstrained(GraphNode constrainedNode, Vector3 clampedPosition)
		{
		}

		public void UpdateInfo()
		{
		}

		public static explicit operator Vector3(NNInfo ob)
		{
			return default(Vector3);
		}

		public static explicit operator GraphNode(NNInfo ob)
		{
			return null;
		}

		public static explicit operator NNInfo(GraphNode ob)
		{
			return default(NNInfo);
		}
	}
}
