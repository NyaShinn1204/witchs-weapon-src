using System.Collections.Generic;
using UnityEngine;

public class GMathBezier
{
	public class BezierData
	{
		public float t;

		public Vector3 result;

		public List<Vector3> pointArr;

		public List<Vector3[]> pointPCArr;

		public List<float> tArr;

		public float distanceXZ
		{
			get
			{
				return 0f;
			}
		}

		public void destroy()
		{
		}
	}

	public static BezierData getBezier(List<Vector3> sPoints, List<float> sTArr, float sT)
	{
		return null;
	}

	public static BezierData getBezier(List<Vector3> sPoints, float sT)
	{
		return null;
	}

	public static BezierData getBezier(BezierData sBezierData, float sT)
	{
		return null;
	}

	private static void mathCPPoint(BezierData sBezierData)
	{
	}

	private static void mathT(BezierData sBezierData)
	{
	}

	private static Vector3 mathBezier(Vector3 sA, Vector3 sB, Vector3 sC, Vector3 sD, float sT)
	{
		return default(Vector3);
	}
}
