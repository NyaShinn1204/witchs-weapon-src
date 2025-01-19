using UnityEngine;

namespace Slate
{
	public abstract class Path : MonoBehaviour
	{
		public abstract float length { get; }

		public abstract Vector3 GetPointAt(float t);

		public abstract void Compute();

		public static Vector3 GetCubicCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
		{
			return default(Vector3);
		}

		public static Vector3 GetQuadraticCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		public static Vector3 GetLinearPoint(Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 GetPoint(float t, params Vector3[] path)
		{
			return default(Vector3);
		}

		public static float GetLength(Vector3[] path)
		{
			return 0f;
		}
	}
}
