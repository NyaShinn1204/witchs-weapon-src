using UnityEngine;

public class StayMotion2 : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool isMoving;

	public void DoMotion()
	{
	}

	private bool IskHitTarget()
	{
		return false;
	}

	public void StartMoveToTarget(AgentEntity entity, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
