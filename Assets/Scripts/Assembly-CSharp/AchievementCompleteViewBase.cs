using System;
using UnityEngine;

public abstract class AchievementCompleteViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public AchievementCompleteViewModel AchievementComplete
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
