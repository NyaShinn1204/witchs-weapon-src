using UnityEngine;

public class ActivityPlayAttributeViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishAttributeAdd;

	[HideInInspector]
	public bool _BindFinishAttributeReset;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishAttributeAddExecuted()
	{
	}

	public virtual void FinishAttributeResetExecuted()
	{
	}

	public override void Bind()
	{
	}
}
