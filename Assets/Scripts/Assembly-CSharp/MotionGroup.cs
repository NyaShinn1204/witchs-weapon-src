using System.Collections.Generic;
using UnityEngine;

public abstract class MotionGroup : Motion
{
	protected List<IMotionEx> subMotions;

	public MotionGroup()
	{
	}

	public List<IMotionEx> GetMotions()
	{
		return null;
	}

	public virtual void AddMotion(IMotionEx motion)
	{
	}

	public override void SetSource(GameObject source)
	{
	}

	public override void SetTarget(GameObject target)
	{
	}

	public override void SetTargetPos(Vector3 pos)
	{
	}

	public override void SetSysProp(BulletSysProperties prop)
	{
	}
}
