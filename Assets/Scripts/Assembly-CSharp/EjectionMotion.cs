using UnityEngine;

public class EjectionMotion : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool startToMove;

	public float maxHeight;

	public float minHeight;

	public float resistance;

	public float timer;

	public float roSpd;

	public float spd;

	public float nextTargetSearchRng;

	public float stepTime;

	public Vector3 velocity;

	protected float dist;

	public Vector3 vFocus;

	public Vector3 vFocus2;

	public float vPos;

	public bool inited;

	public void Init()
	{
	}

	public void DoMotion()
	{
	}

	private bool IskHitTarget()
	{
		return false;
	}

	public void StartMoveToTarget(AgentEntity projectile, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
