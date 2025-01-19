using UnityEngine;

public class GuildMercenaryManagerViewViewBase : GuildMercenaryManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishFresh;

	[HideInInspector]
	public bool _BindFinishAdd;

	[HideInInspector]
	public bool _BindFinishRemove;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishFreshExecuted()
	{
	}

	public virtual void FinishAddExecuted()
	{
	}

	public virtual void FinishRemoveExecuted()
	{
	}

	public override void Bind()
	{
	}
}
