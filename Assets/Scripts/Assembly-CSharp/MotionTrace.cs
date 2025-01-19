using UnityEngine;

public class MotionTrace : MotionLine
{
	public MotionTrace(float speed, int diretion, float acc = 0f, float accMin = 0f, float accMax = 0f, float accReduceRate = 0f)
	{
	}

	protected override Vector3 GetDirection(int diretion, GameObject source, GameObject target)
	{
		return default(Vector3);
	}
}
