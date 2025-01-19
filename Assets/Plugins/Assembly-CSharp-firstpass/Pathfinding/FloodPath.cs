using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class FloodPath : Path
	{
		public Vector3 originalStartPoint;

		public Vector3 startPoint;

		public GraphNode startNode;

		protected Dictionary<GraphNode, GraphNode> parents;

		[Obsolete]
		public FloodPath(Vector3 start, OnPathDelegate callbackDelegate)
		{
		}

		public FloodPath()
		{
		}

		public bool HasPathTo(GraphNode node)
		{
			return false;
		}

		public GraphNode GetParent(GraphNode node)
		{
			return null;
		}

		public static FloodPath Construct(Vector3 start, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, OnPathDelegate callback)
		{
		}

		public override void Reset()
		{
		}

		protected override void Recycle()
		{
		}

		public override void Prepare()
		{
		}

		public override void Initialize()
		{
		}

		public override void CalculateStep(long targetTick)
		{
		}
	}
}
