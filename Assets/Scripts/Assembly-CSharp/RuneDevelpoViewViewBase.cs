using UnityEngine;

public class RuneDevelpoViewViewBase : RuneManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishBreak;

	[HideInInspector]
	public bool _BindFinishAddExp;

	[HideInInspector]
	public bool _BindFinishDentifyConfrim;

	[HideInInspector]
	public bool _BindFinishDentify;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishBreakExecuted()
	{
	}

	public virtual void FinishAddExpExecuted()
	{
	}

	public virtual void FinishDentifyConfrimExecuted()
	{
	}

	public virtual void FinishDentifyExecuted()
	{
	}

	public override void Bind()
	{
	}
}
