using UnityEngine;

public class ServantStarSweepViewViewBase : ProgressSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindSweepFinish;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SweepFinishExecuted()
	{
	}

	public override void Bind()
	{
	}
}
