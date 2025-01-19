using System;
using UnityEngine;

public abstract class ServantListItemViewBase : ViewBase
{
	[HideInInspector]
	public long _ServantID;

	[HideInInspector]
	public int _Lv;

	[HideInInspector]
	public int _Rank;

	[HideInInspector]
	public int _Star;

	[HideInInspector]
	public bool _Wp1CanCompose;

	[HideInInspector]
	public bool _Wp2CanCompose;

	[HideInInspector]
	public bool _isExist;

	[HideInInspector]
	public long _Weapon1ID;

	[HideInInspector]
	public long _Weapon2ID;

	[HideInInspector]
	public bool _Weapon1Unlock;

	[HideInInspector]
	public bool _Weapon2Unlock;

	[HideInInspector]
	public int _Fashion;

	[HideInInspector]
	public int _FavQuestStatus;

	[HideInInspector]
	public long _FavQuestID;

	[HideInInspector]
	public bool _CanPromoteWp1;

	[HideInInspector]
	public bool _CanPromoteWp2;

	[HideInInspector]
	public int _Wp1PromoteLv;

	[HideInInspector]
	public int _Wp2PromoteLv;

	[HideInInspector]
	public bool _Wp3CanCompose;

	[HideInInspector]
	public bool _Wp4CanCompose;

	[HideInInspector]
	public long _Weapon3ID;

	[HideInInspector]
	public long _Weapon4ID;

	[HideInInspector]
	public bool _Weapon3Unlock;

	[HideInInspector]
	public bool _Weapon4Unlock;

	[HideInInspector]
	public bool _CanPromoteWp3;

	[HideInInspector]
	public bool _CanPromoteWp4;

	[HideInInspector]
	public int _Wp3PromoteLv;

	[HideInInspector]
	public int _Wp4PromoteLv;

	[HideInInspector]
	public int _WeaponLevel;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public ServantListItemViewModel ServantListItem
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
}
