using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public class BezierPath : Path
	{
		public int resolution;

		public Color drawColor;

		[SerializeField]
		[HideInInspector]
		private List<BezierPoint> _points;

		private Vector3[] _sampledPathPoints;

		private float _length;

		private bool _closed;

		public List<BezierPoint> points
		{
			get
			{
				return null;
			}
		}

		public bool closed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BezierPoint Item
		{
			get
			{
				return null;
			}
		}

		public int pointCount
		{
			get
			{
				return 0;
			}
		}

		public override float length
		{
			get
			{
				return 0f;
			}
		}

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public override void Compute()
		{
		}

		public void SetDirty()
		{
		}

		private void ComputeLength()
		{
		}

		private void ComputeSampledPathPoints()
		{
		}

		public static BezierPath Create(Transform targetParent = null)
		{
			return null;
		}

		public BezierPoint AddPointAt(Vector3 position, int index = -1)
		{
			return null;
		}

		public void RemovePoint(BezierPoint point)
		{
		}

		public int GetPointIndex(BezierPoint point)
		{
			return 0;
		}

		public static Vector3[] GetSampledPathPoints(BezierPoint p1, BezierPoint p2, int resolution)
		{
			return null;
		}

		public override Vector3 GetPointAt(float t)
		{
			return default(Vector3);
		}

		public static Vector3 GetPoint(BezierPoint p1, BezierPoint p2, float t)
		{
			return default(Vector3);
		}
	}
}
