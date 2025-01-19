using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO
{
	public class RVOQuadtree
	{
		private struct Node
		{
			public int child00;

			public int child01;

			public int child10;

			public int child11;

			public byte count;

			public Agent linkedList;

			public void Add(Agent agent)
			{
			}

			public void Distribute(Node[] nodes, Rect r)
			{
			}
		}

		private const int LeafSize = 15;

		private float maxRadius;

		private Node[] nodes;

		private int filledNodes;

		private Rect bounds;

		public void Clear()
		{
		}

		public void SetBounds(Rect r)
		{
		}

		public int GetNodeIndex()
		{
			return 0;
		}

		public void Insert(Agent agent)
		{
		}

		public void Query(Vector2 p, float radius, Agent agent)
		{
		}

		private float QueryRec(int i, Vector2 p, float radius, Agent agent, Rect r)
		{
			return 0f;
		}

		public void DebugDraw()
		{
		}

		private void DebugDrawRec(int i, Rect r)
		{
		}
	}
}
