using UnityEngine;

public class LinearMotion : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool isMoving;

	public float straightLineTime;

	public float spd;

	public Vector3 velocity;

	public float rotationSpeed;

	protected float maxAngle;

	public bool needReverse;

	public void DoMotion()
	{
	}

	public Vector3 CheckRayCast(Vector3 from, Vector3 to, string name)
	{
		return default(Vector3);
	}

	private bool IskHitTarget()
	{
		return false;
	}

	private bool IsHitGround()
	{
		return false;
	}

	private void BindToBone(int boneIndex = 5)
	{
	}

	public void StartMoveToTarget(AgentEntity entity, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
