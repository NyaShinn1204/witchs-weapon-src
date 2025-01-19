using UnityEngine;

public class StayMotion : MonoBehaviour, IMotion
{
	private Entity target;

	private bool isMoving;

	public PauseType _PauseType;

	private Vector3 offset;

	private Vector3 curPosition;

	private Vector3 nextPosition;

	public void DoMotion()
	{
	}

	private Vector3 GetCenterPosition()
	{
		return default(Vector3);
	}

	public void StartMoveToTarget(AgentEntity entity, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
