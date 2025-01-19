using UnityEngine;

public class PreviewWeaponInfoViewViewBase : CurrentServantWeaponInfoViewBase
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
