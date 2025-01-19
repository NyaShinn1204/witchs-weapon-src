using System;
using UnityEngine;

public abstract class AchievementInProgressViewBase : ViewBase
{
	[HideInInspector]
	public int _Status;

	[HideInInspector]
	public string _Argus;

	[HideInInspector]
	public long _CurrentID;

	[HideInInspector]
	public long _HeadID;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public AchievementInProgressViewModel AchievementInProgress
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
