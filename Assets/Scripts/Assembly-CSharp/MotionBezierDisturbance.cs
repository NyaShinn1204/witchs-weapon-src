using System.Collections.Generic;
using UnityEngine;

public class MotionBezierDisturbance : MotionLine
{
	private Bezier2 bezierLine;

	private Vector3 targetPoint;

	private Vector3 sourcePoint;

	private float controlRate;

	public List<Vector3> disPoints;

	private float disPointDistance;

	private int splitCount;

	private float splitLineDistance;

	private int frameIndex;

	private int pointIndex;

	public MotionBezierDisturbance(float speed, int diretion, float acc = 0f, float accMin = 0f, float accMax = 0f, float accReduceRate = 0f)
	{
	}

	private void caluSplitCount(GameObject projectile, GameObject target)
	{
	}

	public override void SetTarget(GameObject target)
	{
	}

	private Vector3 GetControlPoint(Vector3 startPoint, Vector3 endPoint, float rate)
	{
		return default(Vector3);
	}

	private void ReCalulateBezier()
	{
	}

	public List<Vector3> GetVisualPoints()
	{
		return null;
	}

	private void GenVisualPoints()
	{
	}

	public void DrawBezierRadiusLine()
	{
	}
}
