using UnityEngine;

public class WeaponAndSpellPromoteInfoViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindPromoteWeaponSpell;

	[HideInInspector]
	public bool _BindWeaponSpellPromoteItem1Num;

	[HideInInspector]
	public bool _BindWeaponSpellPromoteItem2Num;

	[HideInInspector]
	public bool _BindWeaponSpellPromoteItem3Num;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void PromoteWeaponSpellExecuted()
	{
	}

	public virtual void WeaponSpellPromoteItem1NumChanged(int value)
	{
	}

	public virtual void WeaponSpellPromoteItem2NumChanged(int value)
	{
	}

	public virtual void WeaponSpellPromoteItem3NumChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
