using UnityEngine;

public class CurrentServantWeaponPromoteSpellViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindPromoteWeaponSpell;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void PromoteWeaponSpellExecuted()
	{
	}

	public override void Bind()
	{
	}
}
