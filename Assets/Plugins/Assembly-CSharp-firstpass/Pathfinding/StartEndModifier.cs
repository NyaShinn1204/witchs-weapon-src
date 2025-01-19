using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class StartEndModifier : PathModifier
	{
		public enum Exactness
		{
			SnapToNode = 0,
			Original = 1,
			Interpolate = 2,
			ClosestOnNode = 3
		}

		public bool addPoints;

		public Exactness exactStartPoint;

		public Exactness exactEndPoint;

		public bool useRaycasting;

		public LayerMask mask;

		public bool useGraphRaycasting;

		public override ModifierData input
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override ModifierData output
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override void Apply(Path _p, ModifierData source)
		{
		}

		public Vector3 GetClampedPoint(Vector3 from, Vector3 to, GraphNode hint)
		{
			return default(Vector3);
		}
	}
}
