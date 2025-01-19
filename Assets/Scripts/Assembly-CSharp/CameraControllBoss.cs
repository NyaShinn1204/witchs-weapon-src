using UnityEngine;

public class CameraControllBoss : MonoBehaviour
{
	private enum CameraControllBossType
	{
		AnimBegin = 0,
		AnimStop = 1,
		End = 2
	}

	private static CameraControllBoss _instance;

	private float _timeTotal;

	private float _time;

	private Vector3 _targetPosition;

	private Vector3 _beginPosition;

	private CameraControllBossType _type;

	public string _ID;

	public static CameraControllBoss instance
	{
		get
		{
			return null;
		}
	}

	public bool IsRunning
	{
		get
		{
			return false;
		}
	}

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 PositionCenter
	{
		get
		{
			return default(Vector3);
		}
	}

	private void Awake()
	{
	}

	public void StartMoveToTarget(string sID, Vector3 sPosition, float sTime = 0.2f)
	{
	}

	public void EndMoveToTarget(string sID, float sTime = 0.2f)
	{
	}

	private void Update()
	{
	}
}
