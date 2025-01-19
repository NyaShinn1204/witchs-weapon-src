using UnityEngine;

public class LinearMotion3 : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool isMoving;

	public Vector3 targetDirection;

	public float spd;

	public Vector3 velocity;

	public bool needReverse;

	private StepMotion motion;

	private float limitAngle;

	private float count;

	private bool isHit;

	public void DoMotion()
	{
	}

	public Vector3 CheckRayCast(Vector3 from, Vector3 to, string name)
	{
		return default(Vector3);
	}

	private bool IsHitGround()
	{
		return false;
	}

	private bool IskHitTarget()
	{
		return false;
	}

	public static bool IsHitTargetInXZ(Entity hitTarget, Entity entity, float hit_distance)
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
