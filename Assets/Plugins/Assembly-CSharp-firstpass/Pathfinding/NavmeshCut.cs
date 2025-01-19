using System;
using System.Collections.Generic;
using Pathfinding.ClipperLib;
using UnityEngine;

namespace Pathfinding
{
	public class NavmeshCut : MonoBehaviour
	{
		public enum MeshType
		{
			Rectangle = 0,
			Circle = 1,
			CustomMesh = 2
		}

		private static List<NavmeshCut> allCuts;

		public MeshType type;

		public Mesh mesh;

		public Vector2 rectangleSize;

		public float circleRadius;

		public int circleResolution;

		public float height;

		public float meshScale;

		public Vector3 center;

		public float updateDistance;

		public bool isDual;

		public bool cutsAddedGeom;

		public float updateRotationDistance;

		public bool useRotation;

		private Vector3[][] contours;

		protected Transform tr;

		private Mesh lastMesh;

		private Vector3 lastPosition;

		private Quaternion lastRotation;

		private bool wasEnabled;

		private Bounds bounds;

		private Bounds lastBounds;

		private static readonly Dictionary<Int2, int> edges;

		private static readonly Dictionary<int, int> pointers;

		public static readonly Color GizmoColor;

		public Bounds LastBounds
		{
			get
			{
				return default(Bounds);
			}
		}

		public static event Action<NavmeshCut> OnDestroyCallback
		{
			add
			{
			}
			remove
			{
			}
		}

		private static void AddCut(NavmeshCut obj)
		{
		}

		private static void RemoveCut(NavmeshCut obj)
		{
		}

		public static List<NavmeshCut> GetAllInRange(Bounds b)
		{
			return null;
		}

		private static bool Intersects(Bounds b1, Bounds b2)
		{
			return false;
		}

		public static List<NavmeshCut> GetAll()
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

		public void ForceUpdate()
		{
		}

		public bool RequiresUpdate()
		{
			return false;
		}

		public virtual void UsedForCut()
		{
		}

		public void NotifyUpdated()
		{
		}

		private void CalculateMeshContour()
		{
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		public void GetContour(List<List<IntPoint>> buffer)
		{
		}

		public IntPoint V3ToIntPoint(Vector3 p)
		{
			return default(IntPoint);
		}

		public Vector3 IntPointToV3(IntPoint p)
		{
			return default(Vector3);
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
