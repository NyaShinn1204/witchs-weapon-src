using UnityEngine;

public class CurrentServantWeaponAddExpViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindSubmitAddWeaponExp;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SubmitAddWeaponExpExecuted()
	{
	}

	public override void Bind()
	{
	}
}
