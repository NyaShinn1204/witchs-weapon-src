using System.Collections.Generic;
using UnityEngine;

public class Bezier2
{
	private Vector3 startPoint;

	private Vector3 endPoint;

	private Vector3 controlPoint;

	private int splitCount;

	private List<Vector3> points;

	public Bezier2(Vector3 startPoint, Vector3 endPoint, Vector3 controlPoint, int splitCount = 10)
	{
	}

	private void Calulate()
	{
	}

	public void SetStartPoint(Vector3 startPoint)
	{
	}

	public Vector3 GetStartPoint()
	{
		return default(Vector3);
	}

	public Vector3 GetEndPoint()
	{
		return default(Vector3);
	}

	public void SetControlPoint(Vector3 controlPoint)
	{
	}

	public void SetEndPoint(Vector3 endPoint)
	{
	}

	public void SetSplitCount(int splitCount)
	{
	}

	public List<Vector3> GetPoints()
	{
		return null;
	}

	public float GetDistanceBetweenPoints()
	{
		return 0f;
	}

	public void DrawBezierRadiusLine()
	{
	}

	public void DrawBezierPointLine()
	{
	}
}
