using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class RichFunnel : RichPathPart
	{
		public enum FunnelSimplification
		{
			None = 0,
			Iterative = 1,
			RecursiveBinary = 2,
			RecursiveTrinary = 3
		}

		private List<Vector3> left;

		private List<Vector3> right;

		private List<TriangleMeshNode> nodes;

		public Vector3 exactStart;

		public Vector3 exactEnd;

		private IFunnelGraph graph;

		private int currentNode;

		private Vector3 currentPosition;

		private int tmpCounter;

		private RichPath path;

		private int[] triBuffer;

		public FunnelSimplification funnelSimplificationMode;

		public RichFunnel Initialize(RichPath path, IFunnelGraph graph)
		{
			return null;
		}

		public override void OnEnterPool()
		{
		}

		public void BuildFunnelCorridor(List<GraphNode> nodes, int start, int end)
		{
		}

		public static void SimplifyPath3(IRaycastableGraph rcg, List<GraphNode> nodes, int start, int end, List<GraphNode> result, Vector3 startPoint, Vector3 endPoint, int depth = 0)
		{
		}

		public static void SimplifyPath2(IRaycastableGraph rcg, List<GraphNode> nodes, int start, int end, List<GraphNode> result, Vector3 startPoint, Vector3 endPoint)
		{
		}

		public void SimplifyPath(IRaycastableGraph graph, List<GraphNode> nodes, int start, int end, List<GraphNode> result, Vector3 startPoint, Vector3 endPoint)
		{
		}

		public void UpdateFunnelCorridor(int splitIndex, TriangleMeshNode prefix)
		{
		}

		public Vector3 Update(Vector3 position, List<Vector3> buffer, int numCorners, out bool lastCorner, out bool requiresRepath)
		{
			lastCorner = default(bool);
			requiresRepath = default(bool);
			return default(Vector3);
		}

		public void FindWalls(List<Vector3> wallBuffer, float range)
		{
		}

		private void FindWalls(int nodeIndex, List<Vector3> wallBuffer, Vector3 position, float range)
		{
		}

		public bool FindNextCorners(Vector3 origin, int startIndex, List<Vector3> funnelPath, int numCorners, out bool lastCorner)
		{
			lastCorner = default(bool);
			return false;
		}
	}
}
