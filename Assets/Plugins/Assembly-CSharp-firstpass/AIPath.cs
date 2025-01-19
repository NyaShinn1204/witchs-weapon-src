using System.Collections;
using System.Diagnostics;
using Pathfinding;
using Pathfinding.RVO;
using UnityEngine;

public class AIPath : MonoBehaviour
{
	public float repathRate;

	public Transform target;

	public bool canSearch;

	public bool canMove;

	public float speed;

	public float turningSpeed;

	public float slowdownDistance;

	public float pickNextWaypointDist;

	public float forwardLook;

	public float endReachedDistance;

	public bool closestOnPathCheck;

	protected float minMoveScale;

	protected Seeker seeker;

	protected Transform tr;

	protected float lastRepath;

	protected Path path;

	protected CharacterController controller;

	protected NavmeshController navController;

	protected RVOController rvoController;

	protected Rigidbody rigid;

	protected int currentWaypointIndex;

	protected bool targetReached;

	protected bool canSearchAgain;

	protected Vector3 lastFoundWaypointPosition;

	protected float lastFoundWaypointTime;

	private bool startHasRun;

	protected Vector3 targetPoint;

	protected Vector3 targetDirection;

	public bool TargetReached
	{
		get
		{
			return false;
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	[DebuggerHidden]
	protected IEnumerator RepeatTrySearchPath()
	{
		return null;
	}

	public virtual float TrySearchPath()
	{
		return 0f;
	}

	public virtual void SearchPath()
	{
	}

	public virtual void OnTargetReached()
	{
	}

	public virtual void OnPathComplete(Path _p)
	{
	}

	public virtual Vector3 GetFeetPosition()
	{
		return default(Vector3);
	}

	public virtual void Update()
	{
	}

	protected float XZSqrMagnitude(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	protected virtual Vector3 CalculateVelocity(Vector3 currentPosition)
	{
		return default(Vector3);
	}

	protected virtual void RotateTowards(Vector3 dir)
	{
	}

	protected Vector3 CalculateTargetPoint(Vector3 p, Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}
}
