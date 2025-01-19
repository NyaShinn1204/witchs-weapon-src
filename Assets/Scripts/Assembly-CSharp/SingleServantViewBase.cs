using System;
using UnityEngine;

public abstract class SingleServantViewBase : ViewBase
{
	[HideInInspector]
	public long _ServantCardID;

	[HideInInspector]
	public int _Lv;

	[HideInInspector]
	public long _Exp;

	[HideInInspector]
	public long _FavLv;

	[HideInInspector]
	public long _FavExp;

	[HideInInspector]
	public int _Rank;

	[HideInInspector]
	public int _Star;

	[HideInInspector]
	public int _SpellActiveLevel;

	[HideInInspector]
	public int _SpellPassiveLevel1;

	[HideInInspector]
	public int _SpellPassiveLevel2;

	[HideInInspector]
	public int _SpellPassiveLevel3;

	[HideInInspector]
	public bool _equip1canUse;

	[HideInInspector]
	public bool _equip2CanUse;

	[HideInInspector]
	public bool _equip3CanUse;

	[HideInInspector]
	public bool _equip4CanUse;

	[HideInInspector]
	public bool _equip5CanUse;

	[HideInInspector]
	public bool _equip6CanUse;

	[HideInInspector]
	public long _equip1;

	[HideInInspector]
	public long _equip2;

	[HideInInspector]
	public long _equip3;

	[HideInInspector]
	public long _equip4;

	[HideInInspector]
	public long _equip5;

	[HideInInspector]
	public long _equip6;

	[HideInInspector]
	public bool _equipCanCompse1;

	[HideInInspector]
	public bool _equipCanCompse2;

	[HideInInspector]
	public bool _equipCanCompse3;

	[HideInInspector]
	public bool _equipCanCompse4;

	[HideInInspector]
	public bool _equipCanCompse5;

	[HideInInspector]
	public bool _equipCanCompse6;

	[HideInInspector]
	public long _ExpLimit;

	[HideInInspector]
	public int _WeaponLv;

	[HideInInspector]
	public bool _Weapon1Unlock;

	[HideInInspector]
	public bool _Weapon2Unlock;

	[HideInInspector]
	public int _Wp1PromoteLv;

	[HideInInspector]
	public int _Wp2PromoteLv;

	[HideInInspector]
	public int _Wp1SpPromoteLv;

	[HideInInspector]
	public int _Wp2SpPromoteLv;

	[HideInInspector]
	public bool _ShowCanRankup;

	[HideInInspector]
	public bool _ShowCanStarUp;

	[HideInInspector]
	public int _CurrentImange;

	[HideInInspector]
	public long _FavQuestID;

	[HideInInspector]
	public int _FavQuestStatus;

	[HideInInspector]
	public int _FavQuestMeta;

	[HideInInspector]
	public bool _ShowFavRedStar;

	[HideInInspector]
	public bool _ShowNewImage;

	[HideInInspector]
	public bool _Weapon3Unlock;

	[HideInInspector]
	public bool _Weapon4Unlock;

	[HideInInspector]
	public int _Wp3PromoteLv;

	[HideInInspector]
	public int _Wp4PromoteLv;

	[HideInInspector]
	public int _Wp3SpPromoteLv;

	[HideInInspector]
	public int _Wp4SpPromoteLv;

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

	public SingleServantViewModel SingleServant
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

	public virtual void ExecuteGotoPreServant()
	{
	}

	public virtual void ExecuteGotoNextServant()
	{
	}

	public virtual void ExecuteAddRank()
	{
	}

	public virtual void ExecuteAddSpellActiveLevel(int arg)
	{
	}

	public virtual void ExecuteAddSpellPassiveLevel1(int arg)
	{
	}

	public virtual void ExecuteAddSpellPassiveLevel2(int arg)
	{
	}

	public virtual void ExecuteAddSpellPassiveLevel3(int arg)
	{
	}

	public virtual void ExecuteEquipAll()
	{
	}

	public virtual void ExecuteUseEuip(int arg)
	{
	}

	public virtual void ExecuteAddExp(UseItemArgus arg)
	{
	}

	public virtual void ExecuteComposeEquip(long arg)
	{
	}

	public virtual void ExecuteComposeEquipOneClick(long arg)
	{
	}

	public virtual void ExecuteChangeImage(int arg)
	{
	}

	public virtual void ExecuteReceiveImageFav(int arg)
	{
	}

	public virtual void ExecuteFinishFavQuest()
	{
	}
}
