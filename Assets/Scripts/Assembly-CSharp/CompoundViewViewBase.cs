using UnityEngine;

public class CompoundViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindComposeWeapon;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ComposeWeaponExecuted()
	{
	}

	public override void Bind()
	{
	}
}
