using System;
using UnityEngine;

public abstract class ServantListManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _CurrentServantIndex;

	[HideInInspector]
	public bool _NeedShowRedStar;

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

	public ServantListManagerViewModel ServantListManager
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

	public virtual void ExecuteTestAddServant(long arg)
	{
	}

	public virtual void ExecuteTestChangeServant(string arg)
	{
	}

	public virtual void ExecuteSelectSvFoDevelop(long arg)
	{
	}

	public virtual void ExecuteSelectServantForBattle(string arg)
	{
	}

	public virtual void ExecuteComposeSv(long arg)
	{
	}
}
