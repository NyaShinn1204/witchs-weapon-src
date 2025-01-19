using UnityEngine;

public class CameraControlSuper : MonoBehaviour
{
	public enum CameraTweenType
	{
		LRMove = 0,
		LRRotation = 1
	}

	public class CameraShake
	{
		private float _timeTotal;

		private float _time;

		private int _period;

		private Vector2 _shake;

		private Vector3 _offset;

		public Vector3 offset
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool eventData()
		{
			return false;
		}

		public void setShake(float sTime, int sPeriod = 2, float sX = 0f, float sY = 0.1f)
		{
		}
	}

	public class CameraOffset
	{
		private float _time;

		private float _timeTotal;

		private Vector3 _offset;

		private Vector3 _offsetPre;

		public bool isOpen;

		public Vector3 offset
		{
			get
			{
				return default(Vector3);
			}
		}

		public float fieldOfView
		{
			get
			{
				return 0f;
			}
		}

		public void eventData()
		{
		}

		public void setOffset(Vector3 sOffset, float sTime)
		{
		}

		public void setOffsetAndePreOffset(Vector3 sOffset, float sTime)
		{
		}
	}

	public Vector3 skillOffset;

	public GameObject targetFollower;

	private static CameraControlSuper _instance;

	public CameraTweenType tweenType;

	public float tweenLerp;

	private CameraShake _shake;

	private CameraOffset _offsetSkill;

	private CameraOffset _offsetScene;

	private Vector3 _position;

	private Quaternion _rotation;

	public Vector3 offset;

	private Camera _mainCamera;

	public Vector3 targetPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 targetPositionCenter
	{
		get
		{
			return default(Vector3);
		}
	}

	public static CameraControlSuper instance
	{
		get
		{
			return null;
		}
	}

	public Camera mainCamera
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void eventMove()
	{
	}

	private void eventReal()
	{
	}

	public void reset()
	{
	}

	public void resetRotation()
	{
	}

	public void setShake(float sTime, int sPeriod, float sX, float sY, float sDecayRate)
	{
	}

	public void setOffsetSkill(Vector3 sOffset)
	{
	}

	public void setOffsetSkillOff()
	{
	}

	public void setOffsetScene(Vector3 sOffset)
	{
	}
}
