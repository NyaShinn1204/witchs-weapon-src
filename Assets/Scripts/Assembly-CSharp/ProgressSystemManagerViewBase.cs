using System;
using UnityEngine;

public abstract class ProgressSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public long _NewUnlockLevel;

	[HideInInspector]
	public int _SweepResult;

	[HideInInspector]
	public int _WeaponChooseTime;

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

	public ProgressSystemManagerViewModel ProgressSystemManager
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

	public virtual void ExecuteSelectlLevelByID(long arg)
	{
	}

	public virtual void ExecuteResetBattleCount()
	{
	}

	public virtual void ExecuteSweep(SweepArgu arg)
	{
	}

	public virtual void ExecuteSweepFinish()
	{
	}

	public virtual void ExecuteResetBattleCountByID(long arg)
	{
	}

	public virtual void ExecuteSetTargetWeapon(long arg)
	{
	}
}
