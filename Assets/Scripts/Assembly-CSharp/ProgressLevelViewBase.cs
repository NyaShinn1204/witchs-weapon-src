using System;
using UnityEngine;

public abstract class ProgressLevelViewBase : ViewBase
{
	[HideInInspector]
	public long _LevelId;

	[HideInInspector]
	public bool _CanFight;

	[HideInInspector]
	public bool _IsClear;

	[HideInInspector]
	public int _BattleCount;

	[HideInInspector]
	public int _BattleCountMax;

	[HideInInspector]
	public bool _CanSweep;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public ProgressLevelViewModel ProgressLevel
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
