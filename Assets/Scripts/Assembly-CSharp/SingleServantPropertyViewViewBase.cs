using UnityEngine;

public class SingleServantPropertyViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindServantPropertyComputedProperty;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ServantPropertyComputedPropertyChanged(ServantPropertyInfo value)
	{
	}

	public override void Bind()
	{
	}
}
