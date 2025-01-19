using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class ConstantPath : Path
	{
		public GraphNode startNode;

		public Vector3 startPoint;

		public Vector3 originalStartPoint;

		public List<GraphNode> allNodes;

		public PathEndingCondition endingCondition;

		public ConstantPath()
		{
		}

		[Obsolete]
		public ConstantPath(Vector3 start, OnPathDelegate callbackDelegate)
		{
		}

		[Obsolete]
		public ConstantPath(Vector3 start, int maxGScore, OnPathDelegate callbackDelegate)
		{
		}

		public static ConstantPath Construct(Vector3 start, int maxGScore, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, int maxGScore, OnPathDelegate callback)
		{
		}

		public override void OnEnterPool()
		{
		}

		protected override void Recycle()
		{
		}

		public override void Reset()
		{
		}

		public override void Prepare()
		{
		}

		public override void Initialize()
		{
		}

		public override void Cleanup()
		{
		}

		public override void CalculateStep(long targetTick)
		{
		}
	}
}
