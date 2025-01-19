using System;
using UnityEngine;

public abstract class DailyInstanceViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	[HideInInspector]
	public bool _CanFight;

	[HideInInspector]
	public bool _IsPass;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public DailyInstanceViewModel DailyInstance
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
