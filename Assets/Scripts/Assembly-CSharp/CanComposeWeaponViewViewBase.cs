using UnityEngine;

public class CanComposeWeaponViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindCanComposeWeapon1;

	[HideInInspector]
	public bool _BindCanComposeWeapon2;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void CanComposeWeapon1Changed(bool value)
	{
	}

	public virtual void CanComposeWeapon2Changed(bool value)
	{
	}

	public override void Bind()
	{
	}
}
