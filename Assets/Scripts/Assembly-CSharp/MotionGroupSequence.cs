using UnityEngine;

public class MotionGroupSequence : MotionGroup
{
	private new Vector3 targetPos;

	public static float DISTANCE;

	public override int Move()
	{
		return 0;
	}

	public override void SetTarget(GameObject target)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
