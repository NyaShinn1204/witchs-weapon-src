using UnityEngine;

namespace Pathfinding
{
	public class RelevantGraphSurface : MonoBehaviour
	{
		private static RelevantGraphSurface root;

		public float maxRange;

		private RelevantGraphSurface prev;

		private RelevantGraphSurface next;

		private Vector3 position;

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
		}

		public RelevantGraphSurface Next
		{
			get
			{
				return null;
			}
		}

		public RelevantGraphSurface Prev
		{
			get
			{
				return null;
			}
		}

		public static RelevantGraphSurface Root
		{
			get
			{
				return null;
			}
		}

		public void UpdatePosition()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static void UpdateAllPositions()
		{
		}

		public static void FindAllGraphSurfaces()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
