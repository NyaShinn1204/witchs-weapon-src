using System;
using UnityEngine;

public abstract class GuildUserManagerViewBase : ViewBase
{
	[HideInInspector]
	public bool _isOpen;

	[HideInInspector]
	public long _LastTimeLeaveGuild;

	[HideInInspector]
	public int _GuildOpResult;

	[HideInInspector]
	public GuildStateEnum _State;

	[HideInInspector]
	public long _GuildCurrency;

	[HideInInspector]
	public int _GuildListPageNum;

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

	public GuildUserManagerViewModel GuildUserManager
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

	public virtual void ExecuteSearchGuild(string arg)
	{
	}

	public virtual void ExecuteRequestGuild(string arg)
	{
	}

	public virtual void ExecuteCancelRequest(string arg)
	{
	}

	public virtual void ExecuteCreateGuild(GuildCreateArgu arg)
	{
	}

	public virtual void ExecuteFinishSearch()
	{
	}

	public virtual void ExecuteFinishCreate()
	{
	}

	public virtual void ExecuteFinishRequest()
	{
	}

	public virtual void ExecuteFinishCancel()
	{
	}

	public virtual void ExecuteSynchronize()
	{
	}

	public virtual void ExecuteFinishSynchronize()
	{
	}

	public virtual void ExecuteGetAllGuild(int arg)
	{
	}

	public virtual void ExecuteSearchGuildByCE(int arg)
	{
	}

	public virtual void ExecuteSearchGuildByMember(int arg)
	{
	}
}
