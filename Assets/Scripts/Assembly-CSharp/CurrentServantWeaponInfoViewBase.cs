using System;
using UnityEngine;

public abstract class CurrentServantWeaponInfoViewBase : ViewBase
{
	[HideInInspector]
	public long _CurrentWeaponCardID;

	[HideInInspector]
	public long _WeaponExp;

	[HideInInspector]
	public long _WeaponLevel;

	[HideInInspector]
	public bool _IsUnlock;

	[HideInInspector]
	public int _WeaponSpellPromoteLv;

	[HideInInspector]
	public int _WeaponSpellPromoteItem1Num;

	[HideInInspector]
	public int _WeaponSpellPromoteItem2Num;

	[HideInInspector]
	public int _WeaponSpellPromoteItem3Num;

	[HideInInspector]
	public int _composeItem1Num;

	[HideInInspector]
	public int _composeItem2Num;

	[HideInInspector]
	public int _composeItem3Num;

	[HideInInspector]
	public long _Weapon1ID;

	[HideInInspector]
	public long _Weapon2ID;

	[HideInInspector]
	public bool _CanComposeWeapon1;

	[HideInInspector]
	public bool _CanComposeWeapon2;

	[HideInInspector]
	public int _ServantWeaponSpellLv;

	[HideInInspector]
	public int _CurrentSkinIndex;

	[HideInInspector]
	public int _SkinState;

	[HideInInspector]
	public bool _CanPromoteWp1;

	[HideInInspector]
	public bool _CanPromoteWp2;

	[HideInInspector]
	public long _Weapon3ID;

	[HideInInspector]
	public long _Weapon4ID;

	[HideInInspector]
	public bool _CanComposeWeapon3;

	[HideInInspector]
	public bool _CanComposeWeapon4;

	[HideInInspector]
	public bool _CanPromoteWp3;

	[HideInInspector]
	public bool _CanPromoteWp4;

	public override string DefaultIdentifier
	{
		get
		{
			return null;
		}
	}

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public CurrentServantWeaponInfoViewModel CurrentServantWeaponInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override ViewModel CreateModel()
	{
		return null;
	}

	protected override void InitializeViewModel(ViewModel viewModel)
	{
	}

	public virtual void ExecuteSelectWeapon(long arg)
	{
	}

	public virtual void ExecuteAddWeapon()
	{
	}

	public virtual void ExecuteChangeWeapon(long arg)
	{
	}

	public virtual void ExecuteAddWeaponExp(string arg)
	{
	}

	public virtual void ExecuteTestFakeAddExp(int arg)
	{
	}

	public virtual void ExecuteSubmitAddWeaponExp(UseItemArgus arg)
	{
	}

	public virtual void ExecutePromoteWeaponSpell()
	{
	}

	public virtual void ExecuteComposeWeapon(long arg)
	{
	}

	public virtual void ExecuteSwitchSkin(int arg)
	{
	}
}
