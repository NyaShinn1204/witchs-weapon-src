using UnityEngine;

public class MotionLine : Motion
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

	public MotionLine()
	{
	}

	public MotionLine(float speed, int diretion, float acc = 0f, float accMin = 0f, float accMax = 0f, float accReduceRate = 0f)
	{
	}

	public override void SetBullet(Bullet bullet)
	{
	}

	public override void SetSysProp(BulletSysProperties property)
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void SetAcc(float acc, float accMin, float accMax, float accReduceRate)
	{
	}

	public void SetDirection(Vector3 direction)
	{
	}

	public override int Move()
	{
		return 0;
	}

	protected virtual Vector3 GetDirection(int diretion, GameObject source, GameObject target)
	{
		return default(Vector3);
	}
}
