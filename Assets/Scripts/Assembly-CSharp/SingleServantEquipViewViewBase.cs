using UnityEngine;

public class SingleServantEquipViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindequipCanCompse1;

	[HideInInspector]
	public bool _BindequipCanCompse2;

	[HideInInspector]
	public bool _BindequipCanCompse3;

	[HideInInspector]
	public bool _BindequipCanCompse4;

	[HideInInspector]
	public bool _BindequipCanCompse5;

	[HideInInspector]
	public bool _BindequipCanCompse6;

	[HideInInspector]
	public bool _Bindequip1canUse;

	[HideInInspector]
	public bool _Bindequip2CanUse;

	[HideInInspector]
	public bool _Bindequip3CanUse;

	[HideInInspector]
	public bool _Bindequip4CanUse;

	[HideInInspector]
	public bool _Bindequip5CanUse;

	[HideInInspector]
	public bool _Bindequip6CanUse;

	[HideInInspector]
	public bool _Bindequip1;

	[HideInInspector]
	public bool _Bindequip2;

	[HideInInspector]
	public bool _Bindequip3;

	[HideInInspector]
	public bool _Bindequip4;

	[HideInInspector]
	public bool _Bindequip5;

	[HideInInspector]
	public bool _Bindequip6;

	[HideInInspector]
	public bool _BindRank;

	[HideInInspector]
	public bool _BindAddRank;

	[HideInInspector]
	public bool _BindEquipAll;

	[HideInInspector]
	public bool _BindUseEuip;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void equipCanCompse1Changed(bool value)
	{
	}

	public virtual void equipCanCompse2Changed(bool value)
	{
	}

	public virtual void equipCanCompse3Changed(bool value)
	{
	}

	public virtual void equipCanCompse4Changed(bool value)
	{
	}

	public virtual void equipCanCompse5Changed(bool value)
	{
	}

	public virtual void equipCanCompse6Changed(bool value)
	{
	}

	public virtual void equip1canUseChanged(bool value)
	{
	}

	public virtual void equip2CanUseChanged(bool value)
	{
	}

	public virtual void equip3CanUseChanged(bool value)
	{
	}

	public virtual void equip4CanUseChanged(bool value)
	{
	}

	public virtual void equip5CanUseChanged(bool value)
	{
	}

	public virtual void equip6CanUseChanged(bool value)
	{
	}

	public virtual void equip1Changed(long value)
	{
	}

	public virtual void equip2Changed(long value)
	{
	}

	public virtual void equip3Changed(long value)
	{
	}

	public virtual void equip4Changed(long value)
	{
	}

	public virtual void equip5Changed(long value)
	{
	}

	public virtual void equip6Changed(long value)
	{
	}

	public virtual void RankChanged(int value)
	{
	}

	public virtual void AddRankExecuted()
	{
	}

	public virtual void EquipAllExecuted()
	{
	}

	public virtual void UseEuipExecuted()
	{
	}

	public override void Bind()
	{
	}
}
