using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class RecastBBTree
	{
		public RecastBBTreeBox root;

		public void QueryInBounds(Rect bounds, List<RecastMeshObj> buffer)
		{
		}

		public void QueryBoxInBounds(RecastBBTreeBox box, Rect bounds, List<RecastMeshObj> boxes)
		{
		}

		public bool Remove(RecastMeshObj mesh)
		{
			return false;
		}

		private RecastBBTreeBox RemoveBox(RecastBBTreeBox c, RecastMeshObj mesh, Rect bounds, ref bool found)
		{
			return null;
		}

		public void Insert(RecastMeshObj mesh)
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmos(RecastBBTreeBox box)
		{
		}

		public void TestIntersections(Vector3 p, float radius)
		{
		}

		public void TestIntersections(RecastBBTreeBox box, Vector3 p, float radius)
		{
		}

		public bool RectIntersectsRect(Rect r, Rect r2)
		{
			return false;
		}

		public bool RectIntersectsCircle(Rect r, Vector3 p, float radius)
		{
			return false;
		}

		public bool RectContains(Rect r, Vector3 p)
		{
			return false;
		}

		public bool ZIntersectsCircle(float z1, float z2, float xpos, Vector3 circle, float radius)
		{
			return false;
		}

		public bool XIntersectsCircle(float x1, float x2, float zpos, Vector3 circle, float radius)
		{
			return false;
		}

		public float ExpansionRequired(Rect r, Rect r2)
		{
			return 0f;
		}

		public Rect ExpandToContain(Rect r, Rect r2)
		{
			return default(Rect);
		}

		public float RectArea(Rect r)
		{
			return 0f;
		}

		public new void ToString()
		{
		}
	}
}
