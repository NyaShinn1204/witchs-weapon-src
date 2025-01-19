using UnityEngine;

public class RoundMotion : MonoBehaviour, IMotion
{
	protected float speed;

	protected float speedLimit;

	protected float acceleration;

	protected Vector3 speedVector;

	private AgentEntity entity;

	private Entity target;

	public bool isMoving;

	private float attackCount;

	public float angleOffset;

	public float baseOffset;

	public int state;

	public const float baseRotateSpd = -28f;

	public const float floatHeight = 0.5f;

	protected Vector3 targetPos;

	private bool isPaused;

	public PauseType _PauseType;

	private float rotateSpeed;

	private Vector3 curPosition;

	private Vector3 nextPosition;

	private Vector3 attackPosition;

	public void DoMotion()
	{
	}

	private void Attack()
	{
	}

	private void RotateToTarget(Vector3 dir)
	{
	}

	private bool IskHitTarget()
	{
		return false;
	}

	private void MoveBack()
	{
	}

	private void FreeMotion()
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
