using UnityEngine;

namespace Pathfinding
{
	public class GraphUpdateScene : GraphModifier
	{
		public Vector3[] points;

		private Vector3[] convexPoints;

		[HideInInspector]
		public bool convex;

		[HideInInspector]
		public float minBoundsHeight;

		[HideInInspector]
		public int penaltyDelta;

		[HideInInspector]
		public bool modifyWalkability;

		[HideInInspector]
		public bool setWalkability;

		[HideInInspector]
		public bool applyOnStart;

		[HideInInspector]
		public bool applyOnScan;

		[HideInInspector]
		public bool useWorldSpace;

		[HideInInspector]
		public bool updatePhysics;

		[HideInInspector]
		public bool resetPenaltyOnPhysics;

		[HideInInspector]
		public bool updateErosion;

		[HideInInspector]
		public bool lockToY;

		[HideInInspector]
		public float lockToYValue;

		[HideInInspector]
		public bool modifyTag;

		[HideInInspector]
		public int setTag;

		private int setTagInvert;

		private bool firstApplied;

		public void Start()
		{
		}

		public override void OnPostScan()
		{
		}

		public virtual void InvertSettings()
		{
		}

		public void RecalcConvex()
		{
		}

		public void ToggleUseWorldSpace()
		{
		}

		public void LockToY()
		{
		}

		public void Apply(AstarPath active)
		{
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		public void Apply()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		public void OnDrawGizmos(bool selected)
		{
		}
	}
}
