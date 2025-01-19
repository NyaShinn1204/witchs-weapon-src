using UnityEngine;

public class SingleServantAddExpViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindAddExp;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void AddExpExecuted()
	{
	}

	public override void Bind()
	{
	}
}
