using UnityEngine;

namespace Pathfinding.Voxels
{
	public class Utility
	{
		public static Color[] colors;

		public static float lastStartTime;

		public static float lastAdditiveTimerStart;

		public static float additiveTimer;

		private static float[] clipPolygonCache;

		private static int[] clipPolygonIntCache;

		public static Color GetColor(int i)
		{
			return default(Color);
		}

		public static int Bit(int a, int b)
		{
			return 0;
		}

		public static Color IntToColor(int i, float a)
		{
			return default(Color);
		}

		public static float TriangleArea2(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		public static float TriangleArea(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		public static float Min(float a, float b, float c)
		{
			return 0f;
		}

		public static float Max(float a, float b, float c)
		{
			return 0f;
		}

		public static int Max(int a, int b, int c, int d)
		{
			return 0;
		}

		public static int Min(int a, int b, int c, int d)
		{
			return 0;
		}

		public static float Max(float a, float b, float c, float d)
		{
			return 0f;
		}

		public static float Min(float a, float b, float c, float d)
		{
			return 0f;
		}

		public static string ToMillis(float v)
		{
			return null;
		}

		public static void StartTimer()
		{
		}

		public static void EndTimer(string label)
		{
		}

		public static void StartTimerAdditive(bool reset)
		{
		}

		public static void EndTimerAdditive(string label, bool log)
		{
		}

		public static void CopyVector(float[] a, int i, Vector3 v)
		{
		}

		public static int ClipPoly(float[] vIn, int n, float[] vOut, float pnx, float pnz, float pd)
		{
			return 0;
		}

		public static int ClipPolygon(float[] vIn, int n, float[] vOut, float multi, float offset, int axis)
		{
			return 0;
		}

		public static int ClipPolygonY(float[] vIn, int n, float[] vOut, float multi, float offset, int axis)
		{
			return 0;
		}

		public static int ClipPolygon(Vector3[] vIn, int n, Vector3[] vOut, float multi, float offset, int axis)
		{
			return 0;
		}

		public static int ClipPolygon(Int3[] vIn, int n, Int3[] vOut, int multi, int offset, int axis)
		{
			return 0;
		}

		public static bool IntersectXAxis(out Vector3 intersection, Vector3 start1, Vector3 dir1, float x)
		{
			intersection = default(Vector3);
			return false;
		}

		public static bool IntersectZAxis(out Vector3 intersection, Vector3 start1, Vector3 dir1, float z)
		{
			intersection = default(Vector3);
			return false;
		}
	}
}
