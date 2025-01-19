using UnityEngine;

public class GroupTraceMotion : MonoBehaviour, IMotion
{
	private AgentEntity entity;

	private Entity target;

	private bool startToMove;

	private Bezier2 bezierLine;

	private int curLinePointIndex;

	private Vector3 targetPoint;

	private int splitCount;

	private float controlRate;

	private GroupObjectPool pool;

	public float spd;

	private float[] groupRateData;

	public void DoMotion()
	{
	}

	private void ChangeDirection()
	{
	}

	private bool CheckPositionChange()
	{
		return false;
	}

	public void StartMoveToTarget(AgentEntity projectile, Entity target)
	{
	}

	private void caluSplitCount(AgentEntity projectile, Entity target)
	{
	}

	private Vector3 GetControlPoint(Vector3 startPoint, Vector3 endPoint, float rate)
	{
		return default(Vector3);
	}

	private void ReCalulateBezier()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void ResetTarget(Entity target)
	{
	}
}
