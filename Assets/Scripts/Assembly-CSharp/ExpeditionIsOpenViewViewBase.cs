using UnityEngine;

public class ExpeditionIsOpenViewViewBase : ExpeditionManagerViewBase
{
	[HideInInspector]
	public bool _BindIsOpen;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void IsOpenChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
