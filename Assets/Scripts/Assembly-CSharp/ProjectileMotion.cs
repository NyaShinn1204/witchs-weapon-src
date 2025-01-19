using UnityEngine;

public class ProjectileMotion : MonoBehaviour, IMotion
{
	private const int BOUNCE_COUNT_MAX = 2;

	private AgentEntity projectile;

	private bool startToMove;

	public float throwTime;

	public float throwPercent;

	public float bounceCount;

	public float bounceTime;

	public float bouncePercent;

	public float rotateTime;

	public float height;

	public float gravity;

	public Vector3 roSpd;

	public Vector3 targetPos;

	public Vector3 currSpeed;

	public float blowCount;

	public float blowRadius;

	private float bounceRange;

	private float rotateRange;

	private Vector3 focus;

	private float spd;

	private float aSpd;

	private Quaternion targetRot;

	public void DoMotion()
	{
	}

	private void RandomRoSpd()
	{
	}

	private void BlowUp()
	{
	}

	private void Bounce()
	{
	}

	private void BounceEnd()
	{
	}

	public void StartMoveToTarget(AgentEntity projectile, Entity target)
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
