using Pathfinding;
using UnityEngine;

public class HeroActionMngr : ActionMngr
{
	public HeroEntity hero;

	public float dashMaxDist;

	public float dashMinDist;

	public static void BindHero(HeroActionMngr haMngr, HeroEntity hUnit)
	{
	}

	public override float GetDashAutoSlowDownRange()
	{
		return 0f;
	}

	public override float GetDashAutoStopRange()
	{
		return 0f;
	}

	public void ResetDefaultState4Player()
	{
	}

	public void ResetTargetdir()
	{
	}

	protected override Vector3 CalculateVelocity(Vector3 currentPosition)
	{
		return default(Vector3);
	}

	public override void UpdateRotation(bool lookAtTarget)
	{
	}

	public override void OnPathComplete(Path _p)
	{
	}
}
