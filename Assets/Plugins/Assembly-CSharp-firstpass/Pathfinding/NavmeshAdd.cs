using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class NavmeshAdd : MonoBehaviour
	{
		public enum MeshType
		{
			Rectangle = 0,
			CustomMesh = 1
		}

		private static List<NavmeshAdd> allCuts;

		public MeshType type;

		public Mesh mesh;

		private Vector3[] verts;

		private int[] tris;

		public Vector2 rectangleSize;

		public float meshScale;

		public Vector3 center;

		private Bounds bounds;

		public bool useRotation;

		protected Transform tr;

		public static readonly Color GizmoColor;

		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
		}

		private static void Add(NavmeshAdd obj)
		{
		}

		private static void Remove(NavmeshAdd obj)
		{
		}

		public static List<NavmeshAdd> GetAllInRange(Bounds b)
		{
			return null;
		}

		private static bool Intersects(Bounds b1, Bounds b2)
		{
			return false;
		}

		public static List<NavmeshAdd> GetAll()
		{
			return null;
		}

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDestroy()
		{
		}

		public void RebuildMesh()
		{
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		public void GetMesh(Int3 offset, ref Int3[] vbuffer, out int[] tbuffer)
		{
			tbuffer = null;
		}
	}
}
