using UnityEngine;

public class ServantEquipSweepViewViewBase : ProgressSystemManagerViewBase
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
