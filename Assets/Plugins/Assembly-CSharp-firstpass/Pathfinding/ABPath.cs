using System;
using UnityEngine;

namespace Pathfinding
{
	public class ABPath : Path
	{
		public bool recalcStartEndCosts;

		public GraphNode startNode;

		public GraphNode endNode;

		public GraphNode startHint;

		public GraphNode endHint;

		public Vector3 originalStartPoint;

		public Vector3 originalEndPoint;

		public Vector3 startPoint;

		public Vector3 endPoint;

		protected bool hasEndPoint;

		public Int3 startIntPoint;

		public bool calculatePartial;

		protected PathNode partialBestTarget;

		protected int[] endNodeCosts;

		[Obsolete]
		public ABPath(Vector3 start, Vector3 end, OnPathDelegate callbackDelegate)
		{
		}

		public ABPath()
		{
		}

		public static ABPath Construct(Vector3 start, Vector3 end, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, Vector3 end, OnPathDelegate callbackDelegate)
		{
		}

		protected void UpdateStartEnd(Vector3 start, Vector3 end)
		{
		}

		public override uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost)
		{
			return 0u;
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

		public void ResetCosts(Path p)
		{
		}

		public override string DebugString(PathLog logMode)
		{
			return null;
		}

		protected override void Recycle()
		{
		}

		public Vector3 GetMovementVector(Vector3 point)
		{
			return default(Vector3);
		}
	}
}
