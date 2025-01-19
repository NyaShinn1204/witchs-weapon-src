using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class SimpleSmoothModifier : MonoModifier
	{
		public enum SmoothType
		{
			Simple = 0,
			Bezier = 1,
			OffsetSimple = 2,
			CurvedNonuniform = 3
		}

		public SmoothType smoothType;

		public int subdivisions;

		public int iterations;

		public float strength;

		public bool uniformLength;

		public float maxSegmentLength;

		public float bezierTangentLength;

		public float offset;

		public float factor;

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

		public override void Apply(Path p, ModifierData source)
		{
		}

		public List<Vector3> CurvedNonuniform(List<Vector3> path)
		{
			return null;
		}

		public static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t)
		{
			return default(Vector3);
		}

		public List<Vector3> SmoothOffsetSimple(List<Vector3> path)
		{
			return null;
		}

		public List<Vector3> SmoothSimple(List<Vector3> path)
		{
			return null;
		}

		public List<Vector3> SmoothBezier(List<Vector3> path)
		{
			return null;
		}
	}
}
