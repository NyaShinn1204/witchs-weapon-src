using System;
using UnityEngine;

public abstract class CurrentServantStarInfoViewBase : ViewBase
{
	[HideInInspector]
	public long _StarInfoID;

	[HideInInspector]
	public int _ItemNum;

	[HideInInspector]
	public int _StarLevel;

	[HideInInspector]
	public int _Cost;

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

	public CurrentServantStarInfoViewModel CurrentServantStarInfo
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

	public virtual void ExecuteAddStarPoint(int arg)
	{
	}

	public virtual void ExecuteAddStartLv()
	{
	}
}
