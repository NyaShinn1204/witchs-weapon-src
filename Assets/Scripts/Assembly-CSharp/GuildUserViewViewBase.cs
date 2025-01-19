using UnityEngine;

public class GuildUserViewViewBase : GuildUserManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishSynchronize;

	[HideInInspector]
	public bool _BindState;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishSynchronizeExecuted()
	{
	}

	public virtual void StateChanged(GuildStateEnum value)
	{
	}

	public override void Bind()
	{
	}
}
