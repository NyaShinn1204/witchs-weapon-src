using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class Polygon
	{
		public static List<Vector3> hullCache;

		public static long TriangleArea2(Int3 a, Int3 b, Int3 c)
		{
			return 0L;
		}

		public static float TriangleArea2(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		public static long TriangleArea(Int3 a, Int3 b, Int3 c)
		{
			return 0L;
		}

		public static float TriangleArea(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		public static bool ContainsPoint(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return false;
		}

		public static bool ContainsPoint(Int2 a, Int2 b, Int2 c, Int2 p)
		{
			return false;
		}

		public static bool ContainsPoint(Int3 a, Int3 b, Int3 c, Int3 p)
		{
			return false;
		}

		public static bool ContainsPoint(Vector2[] polyPoints, Vector2 p)
		{
			return false;
		}

		public static bool ContainsPoint(Vector3[] polyPoints, Vector3 p)
		{
			return false;
		}

		public static bool LeftNotColinear(Vector3 a, Vector3 b, Vector3 p)
		{
			return false;
		}

		public static bool Left(Vector3 a, Vector3 b, Vector3 p)
		{
			return false;
		}

		public static bool Left(Vector2 a, Vector2 b, Vector2 p)
		{
			return false;
		}

		public static bool Left(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool LeftNotColinear(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool Left(Int2 a, Int2 b, Int2 c)
		{
			return false;
		}

		public static bool IsClockwiseMargin(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public static bool IsClockwise(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public static bool IsClockwise(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool IsClockwiseMargin(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool IsClockwiseMargin(Int2 a, Int2 b, Int2 c)
		{
			return false;
		}

		public static bool IsColinear(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool IsColinearAlmost(Int3 a, Int3 b, Int3 c)
		{
			return false;
		}

		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c)
		{
			return false;
		}

		public static bool IntersectsUnclamped(Vector3 a, Vector3 b, Vector3 a2, Vector3 b2)
		{
			return false;
		}

		public static bool Intersects(Int2 a, Int2 b, Int2 a2, Int2 b2)
		{
			return false;
		}

		public static bool Intersects(Int3 a, Int3 b, Int3 a2, Int3 b2)
		{
			return false;
		}

		public static bool Intersects(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return false;
		}

		public static Vector3 IntersectionPointOptimized(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2)
		{
			return default(Vector3);
		}

		public static Vector3 IntersectionPointOptimized(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects)
		{
			intersects = default(bool);
			return default(Vector3);
		}

		public static bool IntersectionFactorRaySegment(Int3 start1, Int3 end1, Int3 start2, Int3 end2)
		{
			return false;
		}

		public static bool IntersectionFactor(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2)
		{
			factor1 = default(float);
			factor2 = default(float);
			return false;
		}

		public static bool IntersectionFactor(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2)
		{
			factor1 = default(float);
			factor2 = default(float);
			return false;
		}

		public static float IntersectionFactorRay(Int3 start1, Int3 end1, Int3 start2, Int3 end2)
		{
			return 0f;
		}

		public static float IntersectionFactor(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return 0f;
		}

		public static Vector3 IntersectionPoint(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return default(Vector3);
		}

		public static Vector3 IntersectionPoint(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects)
		{
			intersects = default(bool);
			return default(Vector3);
		}

		public static Vector2 IntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2)
		{
			return default(Vector2);
		}

		public static Vector2 IntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects)
		{
			intersects = default(bool);
			return default(Vector2);
		}

		public static Vector3 SegmentIntersectionPoint(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects)
		{
			intersects = default(bool);
			return default(Vector3);
		}

		public static Vector3[] ConvexHull(Vector3[] points)
		{
			return null;
		}

		public static bool LineIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b)
		{
			return false;
		}

		public static Vector3[] Subdivide(Vector3[] path, int subdivisions)
		{
			return null;
		}

		public static Vector3 ClosestPointOnTriangle(Vector3[] triangle, Vector3 point)
		{
			return default(Vector3);
		}

		public static Vector3 ClosestPointOnTriangle(Vector3 tr0, Vector3 tr1, Vector3 tr2, Vector3 point)
		{
			return default(Vector3);
		}

		public static float DistanceSegmentSegment3D(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2)
		{
			return 0f;
		}
	}
}
