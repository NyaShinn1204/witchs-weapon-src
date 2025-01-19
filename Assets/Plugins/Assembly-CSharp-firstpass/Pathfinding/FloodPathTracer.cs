using System;
using UnityEngine;

namespace Pathfinding
{
	public class FloodPathTracer : ABPath
	{
		protected FloodPath flood;

		[Obsolete]
		public FloodPathTracer(Vector3 start, FloodPath flood, OnPathDelegate callbackDelegate)
			: base(default(Vector3), default(Vector3), null)
		{
		}

		public FloodPathTracer()
			: base(default(Vector3), default(Vector3), null)
		{
		}

		public static FloodPathTracer Construct(Vector3 start, FloodPath flood, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, FloodPath flood, OnPathDelegate callback)
		{
		}

		public override void Reset()
		{
		}

		protected override void Recycle()
		{
		}

		public override void Initialize()
		{
		}

		public override void CalculateStep(long targetTick)
		{
		}

		public void Trace(GraphNode from)
		{
		}
	}
}
