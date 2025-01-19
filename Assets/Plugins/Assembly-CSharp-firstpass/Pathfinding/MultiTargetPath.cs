using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class MultiTargetPath : ABPath
	{
		public enum HeuristicMode
		{
			None = 0,
			Average = 1,
			MovingAverage = 2,
			Midpoint = 3,
			MovingMidpoint = 4,
			Sequential = 5
		}

		public OnPathDelegate[] callbacks;

		public GraphNode[] targetNodes;

		protected int targetNodeCount;

		public bool[] targetsFound;

		public Vector3[] targetPoints;

		public Vector3[] originalTargetPoints;

		public List<Vector3>[] vectorPaths;

		public List<GraphNode>[] nodePaths;

		public int endsFound;

		public bool pathsForAll;

		public int chosenTarget;

		public int sequentialTarget;

		public HeuristicMode heuristicMode;

		public bool inverted;

		public MultiTargetPath()
			: base(default(Vector3), default(Vector3), null)
		{
		}

		[Obsolete]
		public MultiTargetPath(Vector3[] startPoints, Vector3 target, OnPathDelegate[] callbackDelegates, OnPathDelegate callbackDelegate = null)
			: base(default(Vector3), default(Vector3), null)
		{
		}

		[Obsolete]
		public MultiTargetPath(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callbackDelegate = null)
			: base(default(Vector3), default(Vector3), null)
		{
		}

		public static MultiTargetPath Construct(Vector3[] startPoints, Vector3 target, OnPathDelegate[] callbackDelegates, OnPathDelegate callback = null)
		{
			return null;
		}

		public static MultiTargetPath Construct(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback)
		{
		}

		protected override void Recycle()
		{
		}

		public override void OnEnterPool()
		{
		}

		public override void ReturnPath()
		{
		}

		public void FoundTarget(PathNode nodeR, int i)
		{
		}

		protected void RebuildOpenList()
		{
		}

		public override void Prepare()
		{
		}

		public override void Initialize()
		{
		}

		public void ResetFlags(Path p)
		{
		}

		public override void CalculateStep(long targetTick)
		{
		}

		protected override void Trace(PathNode node)
		{
		}

		public override string DebugString(PathLog logMode)
		{
			return null;
		}
	}
}
