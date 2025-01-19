using System.Collections;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
	public Transform target;

	public float repathRate;

	public float pickNextWaypointDistance;

	public float targetReached;

	public float speed;

	public float rotationSpeed;

	public bool drawGizmos;

	public bool canSearch;

	public bool canMove;

	protected Seeker seeker;

	protected CharacterController controller;

	protected NavmeshController navmeshController;

	protected Transform tr;

	protected float lastPathSearch;

	protected int pathIndex;

	protected Vector3[] path;

	public void Start()
	{
	}

	public void Reset()
	{
	}

	public void OnPathComplete(Path p)
	{
	}

	[DebuggerHidden]
	public IEnumerator WaitToRepath()
	{
		return null;
	}

	public void Stop()
	{
	}

	public void Resume()
	{
	}

	public virtual void Repath()
	{
	}

	public void PathToTarget(Vector3 targetPoint)
	{
	}

	public virtual void ReachedEndOfPath()
	{
	}

	public void Update()
	{
	}

	public void OnDrawGizmos()
	{
	}
}
