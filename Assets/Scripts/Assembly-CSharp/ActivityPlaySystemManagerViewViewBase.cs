using UnityEngine;

public class ActivityPlaySystemManagerViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishGetRewaed;

	[HideInInspector]
	public bool _BindFinishReset;

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

	public override void Bind()
	{
	}
}
