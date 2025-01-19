using UnityEngine;

public class RuneManagerViewViewBase : RuneManagerViewBase
{
	[HideInInspector]
	public bool _BindAllRune;

	[HideInInspector]
	public bool _BindFinishResolveAll;

	[HideInInspector]
	public bool _BindFinishResolve;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void AllRuneAdded(RuneItemViewModel item)
	{
	}

	public virtual void AllRuneRemoved(RuneItemViewModel item)
	{
	}

	public virtual void FinishResolveAllExecuted()
	{
	}

	public virtual void FinishResolveExecuted()
	{
	}

	public override void Bind()
	{
	}
}
