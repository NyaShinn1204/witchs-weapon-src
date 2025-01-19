using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class QuadtreeGraph : NavGraph
	{
		public int editorWidthLog2;

		public int editorHeightLog2;

		public LayerMask layerMask;

		public float nodeSize;

		public int minDepth;

		private QuadtreeNodeHolder root;

		public Vector3 center;

		private BitArray map;

		public int Width { get; protected set; }

		public int Height { get; protected set; }

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public bool CheckCollision(int x, int y)
		{
			return false;
		}

		public int CheckNode(int xs, int ys, int width)
		{
			return 0;
		}

		public override void ScanInternal(OnScanStatus statusCallback)
		{
		}

		public void RecalculateConnectionsRec(QuadtreeNodeHolder holder, int depth, int x, int y)
		{
		}

		public Vector3 LocalToWorldPosition(int x, int y, int width)
		{
			return default(Vector3);
		}

		public void CreateNodeRec(QuadtreeNodeHolder holder, int depth, int x, int y)
		{
		}

		public void RecalculateConnections(QuadtreeNodeHolder holder, int depth, int x, int y)
		{
		}

		public void AddNeighboursRec(List<QuadtreeNode> arr, QuadtreeNodeHolder holder, int depth, int x, int y, IntRect bounds, QuadtreeNode dontInclude)
		{
		}

		public QuadtreeNode QueryPoint(int qx, int qy)
		{
			return null;
		}

		public override void OnDrawGizmos(bool drawNodes)
		{
		}

		public void DrawRec(QuadtreeNodeHolder h, int depth, int x, int y, Vector3 parentPos)
		{
		}
	}
}
