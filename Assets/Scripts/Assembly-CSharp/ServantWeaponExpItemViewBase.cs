using System;
using UnityEngine;

public abstract class ServantWeaponExpItemViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	[HideInInspector]
	public int _Num;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public ServantWeaponExpItemViewModel ServantWeaponExpItem
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
