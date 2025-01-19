using UnityEngine;

namespace Pathfinding
{
	public class GraphUpdateShape
	{
		private Vector3[] _points;

		private Vector3[] _convexPoints;

		private bool _convex;

		public Vector3[] points
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool convex
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void CalculateConvexHull()
		{
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		public bool Contains(GraphNode node)
		{
			return false;
		}

		public bool Contains(Vector3 point)
		{
			return false;
		}
	}
}
