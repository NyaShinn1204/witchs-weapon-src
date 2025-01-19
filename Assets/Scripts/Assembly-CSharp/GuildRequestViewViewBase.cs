using UnityEngine;

public class GuildRequestViewViewBase : GuildUserManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishCreate;

	[HideInInspector]
	public bool _BindFinishSearch;

	[HideInInspector]
	public bool _BindFinishRequest;

	[HideInInspector]
	public bool _BindFinishCancel;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishCreateExecuted()
	{
	}

	public virtual void FinishSearchExecuted()
	{
	}

	public virtual void FinishRequestExecuted()
	{
	}

	public virtual void FinishCancelExecuted()
	{
	}

	public override void Bind()
	{
	}
}
