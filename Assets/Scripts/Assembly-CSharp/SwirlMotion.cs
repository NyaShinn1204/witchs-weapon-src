using UnityEngine;

public class SwirlMotion : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool startToMove;

	public float resistance;

	public float timer;

	public float roSpd;

	public float stepTime;

	public bool inited;

	public void DoMotion()
	{
	}

	private static void RotateSelfToDirectionSmoothly(Transform transform, Vector3 direction, float rotateSpeed)
	{
	}

	private static void PositionToDirectionSmoothly(Transform transform, float speed, float minHeight = 0f, float maxHeight = 0f)
	{
	}

	private bool IsHit(float hitDistance = 0.5f)
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
