using UnityEngine;

public class Rotate
{
	public const int FACETO_NULL = 0;

	public const int FACETO_DIRECTION = 1;

	public const int FACETO_TARGET = 2;

	public const int FACETO_VISUAL_POINT = 3;

	public const int FACETO_START_RANDOM = 1;

	public const int FACETO_START_RANDOM_TANGENT = 2;

	public const int FACETO_START_TARGET = 3;

	public const int FACETO_START_TARGET_UP = 4;

	public const int FACETO_START_RANDOM_BACK = 5;

	private bool isDestroy;

	public string motionSegmentName;

	private IMotionEx motion;

	private Bullet bullet;

	private GameObject source;

	private GameObject target;

	public int faceTo;

	public int faceToStart;

	public float faceToSpeed;

	private float faceToAngle;

	public int rotateCount;

	private Vector3 axis;

	private float angle;

	private float speed;

	private Quaternion curRotate;

	private bool isStart;

	private float slerpRate;

	private int index;

	private int frameIndex;

	private int pointIndex;

	public Rotate(Bullet bullet, IMotionEx motion, int faceTo, float faceToSpeed, Vector3 axis, float angle, float rotSpeed, int faceToStart)
	{
	}

	public void SetTarget(GameObject target)
	{
	}

	public void SetSource(GameObject src)
	{
	}

	private void FaceToStart()
	{
	}

	public static bool IsInValid(Bullet bullet)
	{
		return false;
	}

	public static Vector3 GetEntityPos(GameObject target)
	{
		return default(Vector3);
	}

	public void Update()
	{
	}

	private Vector3 GetVisualPoint(MotionBezierDisturbance motion)
	{
		return default(Vector3);
	}

	private Quaternion GetDirectionQuternion(GameObject source, Vector3 target)
	{
		return default(Quaternion);
	}

	private Quaternion RotateSelfToDirectionSmoothly(Transform transform, Quaternion toTarget, float rotateSpeed)
	{
		return default(Quaternion);
	}

	public Quaternion GetCurQuternion()
	{
		return default(Quaternion);
	}

	public void SetSegmentName(string name)
	{
	}

	public void OnLifeEnd()
	{
	}

	public bool IsDestoried()
	{
		return false;
	}

	public void Reset()
	{
	}
}
