using UnityEngine;

public class UIMoneyGame : GUtilUISuper
{
	private class UIMoneyGameJoy : MonoBehaviour
	{
		public GameObject joy;

		private int _fingerId;

		public Vector3 mousePostionLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public float mouseAngle
		{
			get
			{
				return 0f;
			}
		}

		public bool isRun
		{
			get
			{
				return false;
			}
		}

		public bool isUp
		{
			get
			{
				return false;
			}
		}

		public bool isDown
		{
			get
			{
				return false;
			}
		}

		public bool isLeft
		{
			get
			{
				return false;
			}
		}

		public bool isRight
		{
			get
			{
				return false;
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Begin(int sFingerId)
		{
		}

		public void Stop()
		{
		}
	}

	private UIMoneyGameJoy _joy;

	private Animator _npc;

	private Animator _hero;

	private GameObject _begin;

	private GameObject _help;

	private GameObject _game;

	private GameObject _gameOver;

	private int _combo;

	public int _roundMax;

	public string grade;

	private int _catchScore;

	private int _catchScoreAdd;

	private int _round;

	private float _time;

	public long propID;

	public int propCount;

	private string _listener_str;

	public float _speed
	{
		get
		{
			return 0f;
		}
	}

	private float _timeTotal
	{
		get
		{
			return 0f;
		}
	}

	private bool isBegin
	{
		get
		{
			return false;
		}
	}

	private bool isLock
	{
		get
		{
			return false;
		}
	}

	protected override void Start()
	{
	}

	public void init()
	{
	}

	private void Update()
	{
	}

	private void eventNpc()
	{
	}

	private void eventHero()
	{
	}

	private void eventInfo()
	{
	}

	private void eventGameOver()
	{
	}

	private void resetPosition()
	{
	}

	private void btnGameOver()
	{
	}

	private void gameOver()
	{
	}

	private void btnBegin()
	{
	}

	private void btnInfo()
	{
	}

	private void btnClose()
	{
	}

	private void btnJoyMouseDown()
	{
	}
}
