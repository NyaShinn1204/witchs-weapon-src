using System;
using UnityEngine;

public abstract class AchievementSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _ReceiveResult;

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

	public AchievementSystemManagerViewModel AchievementSystemManager
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

	public virtual void ExecuteGetReward(long arg)
	{
	}

	public virtual void ExecuteFinishGetReward()
	{
	}
}
