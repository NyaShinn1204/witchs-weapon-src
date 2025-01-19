using UnityEngine;

public class Selecter : MonoBehaviour, IPausedComponent
{
	public static Selecter instance;

	public float speedRate;

	public Transform outer;

	public Transform mider;

	public Transform center;

	public float rotSpdOuter;

	public float rotSpdMider;

	public float rotSpdCenter;

	protected const float defaultScale = 3f;

	protected Transform target;

	protected bool isAttackTarget;

	protected Transform lastTarget;

	protected bool lastTargetIsAttackTarget;

	private HeroEntity hero;

	private bool isAssignDelegate;

	private bool canRotate;

	public PauseType _PauseType;

	private float centerAlpha;

	private float _colorRate;

	private float ColorRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CheckTarget()
	{
	}

	private void GetNewTarget()
	{
	}

	private void GetNewAttackTarget()
	{
	}

	private void Recovery()
	{
	}

	private void Rotate()
	{
	}

	private void SetScale(Transform t, float scale)
	{
	}

	private void RecoveryScale(Transform t, float df = 0.5f)
	{
	}

	public void OnDestroy()
	{
	}
}
