using System;
using UnityEngine;

public abstract class DailyInstanceSetViewBase : ViewBase
{
	[HideInInspector]
	public long _Id;

	[HideInInspector]
	public int _EnterCounts;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public DailyInstanceSetViewModel DailyInstanceSet
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
