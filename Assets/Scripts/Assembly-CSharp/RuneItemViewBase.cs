using System;
using UnityEngine;

public abstract class RuneItemViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	[HideInInspector]
	public long _RuneID;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public RuneItemViewModel RuneItem
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
