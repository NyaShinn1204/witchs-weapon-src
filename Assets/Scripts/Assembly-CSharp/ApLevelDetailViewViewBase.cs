using UnityEngine;

public class ApLevelDetailViewViewBase : ActivityPlaySystemManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishSweep;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishSweepExecuted()
	{
	}

	public override void Bind()
	{
	}
}
