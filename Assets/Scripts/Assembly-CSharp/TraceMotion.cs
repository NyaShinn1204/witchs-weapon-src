using UnityEngine;

public class TraceMotion : MonoBehaviour, IMotion
{
	public float aSpeed;

	protected float speed;

	private AgentEntity entity;

	private Entity target;

	private bool startToMove;

	public void DoMotion()
	{
	}

	public void StartMoveToTarget(AgentEntity projectile, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
