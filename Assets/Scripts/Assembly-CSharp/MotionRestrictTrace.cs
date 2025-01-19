using UnityEngine;

public class MotionRestrictTrace : MotionTrace
{
	public Vector3 targetDirection;

	private StepMotion motion;

	private float limitAngle;

	private bool inited;

	private Vector3 speedDirection;

	public MotionRestrictTrace(float speed, int diretion, float acc = 0f, float accMin = 0f, float accMax = 0f, float accReduceRate = 0f, float limitAngle = 0f)
		: base(0f, 0)
	{
	}

	public override void SetTarget(GameObject target)
	{
	}

	public override int Move()
	{
		return 0;
	}

	private Vector3 RayCheck(string targetName)
	{
		return default(Vector3);
	}

	protected override Vector3 GetDirection(int diretion, GameObject source, GameObject target)
	{
		return default(Vector3);
	}
}
