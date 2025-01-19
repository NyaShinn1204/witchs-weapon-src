using UnityEngine;

public class ActivityPlaySystemManagerRule1ViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishGetRewaed;

	[HideInInspector]
	public bool _BindFinishReset;

	[HideInInspector]
	public bool _BindFinishGoToNextFloorRule1;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishGetRewaedExecuted()
	{
	}

	public virtual void FinishResetExecuted()
	{
	}

	public virtual void FinishGoToNextFloorRule1Executed()
	{
	}

	public override void Bind()
	{
	}
}
