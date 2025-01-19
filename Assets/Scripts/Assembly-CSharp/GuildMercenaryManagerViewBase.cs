using System;
using UnityEngine;

public abstract class GuildMercenaryManagerViewBase : ViewBase
{
	[HideInInspector]
	public int _MaxSvNum;

	[HideInInspector]
	public int _OpResult;

	[HideInInspector]
	public int _Mode;

	[HideInInspector]
	public long _RemoveMercenaryReward;

	[HideInInspector]
	public long _RemoveMecGoldReward;

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

	public GuildMercenaryManagerViewModel GuildMercenaryManager
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

	public virtual void ExecuteAddSv(AddSvArgu arg)
	{
	}

	public virtual void ExecuteRemoveSv(long arg)
	{
	}

	public virtual void ExecuteFreshMercenariesList()
	{
	}

	public virtual void ExecuteFinishFresh()
	{
	}

	public virtual void ExecuteFinishAdd()
	{
	}

	public virtual void ExecuteFinishRemove()
	{
	}

	public virtual void ExecuteFreshCanHireList()
	{
	}

	public virtual void ExecuteFinishFreshCanHireList()
	{
	}

	public virtual void ExecuteSelectBattleGroup(SelectSvGroup arg)
	{
	}

	public virtual void ExecuteFinishSelectBattleGroup()
	{
	}

	public virtual void ExecuteHireMercenary(SelectSvGroup arg)
	{
	}

	public virtual void ExecuteFinishHireMercenary()
	{
	}
}
