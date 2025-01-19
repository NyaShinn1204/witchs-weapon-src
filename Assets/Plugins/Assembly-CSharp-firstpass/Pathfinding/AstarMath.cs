using UnityEngine;

namespace Pathfinding
{
	public class AstarMath
	{
		public static int ComputeVertexHash(int x, int y, int z)
		{
			return 0;
		}

		public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		public static float NearestPointFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return 0f;
		}

		public static float NearestPointFactor(Int3 lineStart, Int3 lineEnd, Int3 point)
		{
			return 0f;
		}

		public static float NearestPointFactor(Int2 lineStart, Int2 lineEnd, Int2 point)
		{
			return 0f;
		}

		public static Vector3 NearestPointStrict(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		public static Vector3 NearestPointStrictXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		public static float DistancePointSegment(int x, int z, int px, int pz, int qx, int qz)
		{
			return 0f;
		}

		public static float DistancePointSegment(Int3 a, Int3 b, Int3 p)
		{
			return 0f;
		}

		public static float DistancePointSegment2(int x, int z, int px, int pz, int qx, int qz)
		{
			return 0f;
		}

		public static float DistancePointSegment2(Vector3 a, Vector3 b, Vector3 p)
		{
			return 0f;
		}

		public static float DistancePointSegmentStrict(Vector3 a, Vector3 b, Vector3 p)
		{
			return 0f;
		}

		public static float Hermite(float start, float end, float value)
		{
			return 0f;
		}

		public static Vector3 CubicBezier(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		public static float MapTo(float startMin, float startMax, float value)
		{
			return 0f;
		}

		public static float MapToRange(float targetMin, float targetMax, float value)
		{
			return 0f;
		}

		public static float MapTo(float startMin, float startMax, float targetMin, float targetMax, float value)
		{
			return 0f;
		}

		public static string FormatBytes(int bytes)
		{
			return null;
		}

		public static string FormatBytesBinary(int bytes)
		{
			return null;
		}

		public static int Bit(int a, int b)
		{
			return 0;
		}

		public static Color IntToColor(int i, float a)
		{
			return default(Color);
		}

		public static float MagnitudeXZ(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static float SqrMagnitudeXZ(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static int Repeat(int i, int n)
		{
			return 0;
		}

		public static float Abs(float a)
		{
			return 0f;
		}

		public static int Abs(int a)
		{
			return 0;
		}

		public static float Min(float a, float b)
		{
			return 0f;
		}

		public static int Min(int a, int b)
		{
			return 0;
		}

		public static uint Min(uint a, uint b)
		{
			return 0u;
		}

		public static float Max(float a, float b)
		{
			return 0f;
		}

		public static int Max(int a, int b)
		{
			return 0;
		}

		public static uint Max(uint a, uint b)
		{
			return 0u;
		}

		public static ushort Max(ushort a, ushort b)
		{
			return 0;
		}

		public static float Sign(float a)
		{
			return 0f;
		}

		public static int Sign(int a)
		{
			return 0;
		}

		public static float Clamp(float a, float b, float c)
		{
			return 0f;
		}

		public static int Clamp(int a, int b, int c)
		{
			return 0;
		}

		public static float Clamp01(float a)
		{
			return 0f;
		}

		public static int Clamp01(int a)
		{
			return 0;
		}

		public static float Lerp(float a, float b, float t)
		{
			return 0f;
		}

		public static int RoundToInt(float v)
		{
			return 0;
		}

		public static int RoundToInt(double v)
		{
			return 0;
		}
	}
}
