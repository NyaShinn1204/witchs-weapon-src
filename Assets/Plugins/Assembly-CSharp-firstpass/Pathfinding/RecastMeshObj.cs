using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class RecastMeshObj : MonoBehaviour
	{
		protected static RecastBBTree tree;

		protected static List<RecastMeshObj> dynamicMeshObjs;

		[HideInInspector]
		public Bounds bounds;

		public bool dynamic;

		public int area;

		private bool _dynamic;

		private bool registered;

		public static void GetAllInBounds(List<RecastMeshObj> buffer, Bounds bounds)
		{
		}

		private void OnEnable()
		{
		}

		private void Register()
		{
		}

		private void RecalculateBounds()
		{
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		public MeshFilter GetMeshFilter()
		{
			return null;
		}

		public Collider GetCollider()
		{
			return null;
		}

		private void OnDisable()
		{
		}
	}
}
