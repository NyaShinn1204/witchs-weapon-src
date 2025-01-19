using UnityEngine;

public class CurrentServantWeaponInfoViewViewBase : CurrentServantWeaponInfoViewBase
{
	[HideInInspector]
	public bool _BindSelectWeapon;

	[HideInInspector]
	public bool _BindWeaponExp;

	[HideInInspector]
	public bool _BindWeaponLevel;

	[HideInInspector]
	public bool _BindAddWeapon;

	[HideInInspector]
	public bool _BindChangeWeapon;

	[HideInInspector]
	public bool _BindSubmitAddWeaponExp;

	[HideInInspector]
	public bool _BindCurrentWeaponCardID;

	[HideInInspector]
	public bool _BindIsUnlock;

	[HideInInspector]
	public bool _BindWeaponSpellPromoteLv;

	[HideInInspector]
	public bool _BindcomposeItem1Num;

	[HideInInspector]
	public bool _BindcomposeItem2Num;

	[HideInInspector]
	public bool _BindcomposeItem3Num;

	[HideInInspector]
	public bool _BindComposeWeapon;

	[HideInInspector]
	public bool _BindCanComposeWeapon1;

	[HideInInspector]
	public bool _BindCanComposeWeapon2;

	[HideInInspector]
	public bool _BindServantWeaponSpellLv;

	[HideInInspector]
	public bool _BindCanPromoteWp1;

	[HideInInspector]
	public bool _BindCanPromoteWp2;

	[HideInInspector]
	public bool _BindCanComposeWeapon3;

	[HideInInspector]
	public bool _BindCanComposeWeapon4;

	[HideInInspector]
	public bool _BindCanPromoteWp3;

	[HideInInspector]
	public bool _BindCanPromoteWp4;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SelectWeaponExecuted()
	{
	}

	public virtual void WeaponExpChanged(long value)
	{
	}

	public virtual void WeaponLevelChanged(long value)
	{
	}

	public virtual void AddWeaponExecuted()
	{
	}

	public virtual void ChangeWeaponExecuted()
	{
	}

	public virtual void SubmitAddWeaponExpExecuted()
	{
	}

	public virtual void CurrentWeaponCardIDChanged(long value)
	{
	}

	public virtual void IsUnlockChanged(bool value)
	{
	}

	public virtual void WeaponSpellPromoteLvChanged(int value)
	{
	}

	public virtual void composeItem1NumChanged(int value)
	{
	}

	public virtual void composeItem2NumChanged(int value)
	{
	}

	public virtual void composeItem3NumChanged(int value)
	{
	}

	public virtual void ComposeWeaponExecuted()
	{
	}

	public virtual void CanComposeWeapon1Changed(bool value)
	{
	}

	public virtual void CanComposeWeapon2Changed(bool value)
	{
	}

	public virtual void ServantWeaponSpellLvChanged(int value)
	{
	}

	public virtual void CanPromoteWp1Changed(bool value)
	{
	}

	public virtual void CanPromoteWp2Changed(bool value)
	{
	}

	public virtual void CanComposeWeapon3Changed(bool value)
	{
	}

	public virtual void CanComposeWeapon4Changed(bool value)
	{
	}

	public virtual void CanPromoteWp3Changed(bool value)
	{
	}

	public virtual void CanPromoteWp4Changed(bool value)
	{
	}

	public override void Bind()
	{
	}
}
