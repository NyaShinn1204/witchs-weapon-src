using UnityEngine;

public class ServantListManagerViewViewBase : ServantListManagerViewBase
{
	[HideInInspector]
	public bool _BindUserServants;

	[HideInInspector]
	public bool _UserServantsSceneFirst;

	[HideInInspector]
	public Transform _UserServantsContainer;

	[HideInInspector]
	public bool _BindComposeSv;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual ViewBase CreateUserServantsView(ServantListItemViewModel item)
	{
		return null;
	}

	public virtual void UserServantsAdded(ViewBase item)
	{
	}

	public virtual void UserServantsRemoved(ViewBase item)
	{
	}

	public virtual void ComposeSvExecuted()
	{
	}

	public override void Bind()
	{
	}
}
