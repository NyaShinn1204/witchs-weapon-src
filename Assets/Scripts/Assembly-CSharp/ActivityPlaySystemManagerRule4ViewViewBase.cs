using UnityEngine;

public class ActivityPlaySystemManagerRule4ViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishGetRewaed;

	[HideInInspector]
	public bool _BindFinishReset;

	[HideInInspector]
	public bool _BindFinishR4ChooseMobLevel;

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

	public virtual void FinishR4ChooseMobLevelExecuted()
	{
	}

	public override void Bind()
	{
	}
}
