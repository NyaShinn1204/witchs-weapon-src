using System;
using UnityEngine;

public abstract class ExpeditionManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _CurrentIndex;

	[HideInInspector]
	public int _ResetResult;

	[HideInInspector]
	public int _ReceiveChestResult;

	[HideInInspector]
	public long _ChestGold;

	[HideInInspector]
	public int _hp;

	[HideInInspector]
	public int _EnterCount;

	[HideInInspector]
	public bool _IsOpen;

	[HideInInspector]
	public int _CscCurrency;

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

	public ExpeditionManagerViewModel ExpeditionManager
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

	public virtual void ExecuteResetExpedition()
	{
	}

	public virtual void ExecuteCommitExpeditionServant(CommitExpeditionServant arg)
	{
	}

	public virtual void ExecuteReceiveChest()
	{
	}

	public virtual void ExecuteRefreshExpedition()
	{
	}

	public virtual void ExecuteFinishReset()
	{
	}

	public virtual void ExecuteFinishLoot()
	{
	}

	public virtual void ExecuteGetRank(int arg)
	{
	}

	public virtual void ExecuteFinishGetRank()
	{
	}
}
