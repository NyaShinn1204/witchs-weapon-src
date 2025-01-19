using UnityEngine;

public class MotionGroupParallel : MotionGroup, ICorrectable
{
	private bool isAddNew;

	private ICorrector corrector;

	public void SetCorrector(ICorrector corrector)
	{
	}

	public override void ResetLife()
	{
	}

	public override void AddMotion(IMotionEx motion)
	{
	}

	public override int Move()
	{
		return 0;
	}

	public override void SetTarget(GameObject target)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
