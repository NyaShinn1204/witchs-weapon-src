using UnityEngine;

public class ServantListItemViewViewBase : ServantListItemViewBase
{
	[HideInInspector]
	public bool _BindLv;

	[HideInInspector]
	public bool _BindRank;

	[HideInInspector]
	public bool _BindStar;

	[HideInInspector]
	public bool _BindisExist;

	[HideInInspector]
	public bool _BindWeapon1Unlock;

	[HideInInspector]
	public bool _BindWeapon2Unlock;

	[HideInInspector]
	public bool _BindFashion;

	[HideInInspector]
	public bool _BindWp2CanCompose;

	[HideInInspector]
	public bool _BindWp1CanCompose;

	[HideInInspector]
	public bool _BindCanPromoteWp1;

	[HideInInspector]
	public bool _BindCanPromoteWp2;

	[HideInInspector]
	public bool _BindWp1PromoteLv;

	[HideInInspector]
	public bool _BindWp2PromoteLv;

	[HideInInspector]
	public bool _BindWeapon3Unlock;

	[HideInInspector]
	public bool _BindWeapon4Unlock;

	[HideInInspector]
	public bool _BindCanPromoteWp3;

	[HideInInspector]
	public bool _BindCanPromoteWp4;

	[HideInInspector]
	public bool _BindWp3PromoteLv;

	[HideInInspector]
	public bool _BindWp4PromoteLv;

	[HideInInspector]
	public bool _BindWp3CanCompose;

	[HideInInspector]
	public bool _BindWp4CanCompose;

	[HideInInspector]
	public bool _BindWeaponLevel;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void LvChanged(int value)
	{
	}

	public virtual void RankChanged(int value)
	{
	}

	public virtual void StarChanged(int value)
	{
	}

	public virtual void isExistChanged(bool value)
	{
	}

	public virtual void Weapon1UnlockChanged(bool value)
	{
	}

	public virtual void Weapon2UnlockChanged(bool value)
	{
	}

	public virtual void FashionChanged(int value)
	{
	}

	public virtual void Wp2CanComposeChanged(bool value)
	{
	}

	public virtual void Wp1CanComposeChanged(bool value)
	{
	}

	public virtual void CanPromoteWp1Changed(bool value)
	{
	}

	public virtual void CanPromoteWp2Changed(bool value)
	{
	}

	public virtual void Wp1PromoteLvChanged(int value)
	{
	}

	public virtual void Wp2PromoteLvChanged(int value)
	{
	}

	public virtual void Weapon3UnlockChanged(bool value)
	{
	}

	public virtual void Weapon4UnlockChanged(bool value)
	{
	}

	public virtual void CanPromoteWp3Changed(bool value)
	{
	}

	public virtual void CanPromoteWp4Changed(bool value)
	{
	}

	public virtual void Wp3PromoteLvChanged(int value)
	{
	}

	public virtual void Wp4PromoteLvChanged(int value)
	{
	}

	public virtual void Wp3CanComposeChanged(bool value)
	{
	}

	public virtual void Wp4CanComposeChanged(bool value)
	{
	}

	public virtual void WeaponLevelChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
