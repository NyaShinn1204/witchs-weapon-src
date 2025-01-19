using UnityEngine;

public class MotionSleep : Motion
{
	public float speed;

	public Vector3 direction;

	public float acc;

	public float accMin;

	public float accMax;

	public float accReduceRate;

	protected int dir;

	protected Vector3 targetDir;

	private Vector3 targetsave;

	public MotionSleep()
	{
	}

	public MotionSleep(float speed)
	{
	}

	public override int Move()
	{
		return 0;
	}
}
