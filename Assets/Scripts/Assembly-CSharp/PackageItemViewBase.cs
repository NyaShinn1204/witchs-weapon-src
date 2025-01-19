using System;
using UnityEngine;

public abstract class PackageItemViewBase : ViewBase
{
	[HideInInspector]
	public long _ID;

	[HideInInspector]
	public string _Name;

	[HideInInspector]
	public long _Num;

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public PackageItemViewModel PackageItem
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
