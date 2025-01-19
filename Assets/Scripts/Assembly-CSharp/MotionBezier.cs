using UnityEngine;

public class MotionBezier : Motion
{
	private Bezier2 bezierLine;

	private float speed;

	private float controlPointRate;

	private int splitCount;

	private float controlRate;

	private int curLinePointIndex;

	private Vector3 targetPoint;

	private Vector3 sourcePoint;

	public MotionBezier(Vector3 startPoint, float controlPointRate, float speed = 1f)
	{
	}

	public override void SetTarget(GameObject target)
	{
	}

	private void caluSplitCount(GameObject projectile, GameObject target)
	{
	}

	private Vector3 GetControlPoint(Vector3 startPoint, Vector3 endPoint, float rate)
	{
		return default(Vector3);
	}

	private void ReCalulateBezier()
	{
	}

	private bool CheckPositionChange()
	{
		return false;
	}

	public override int Move()
	{
		return 0;
	}

	public void DrawBezier()
	{
	}

	private void ChangeDirection()
	{
	}
}
