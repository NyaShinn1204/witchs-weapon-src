using System;
using UnityEngine;

public abstract class GuildManagerViewBase : ViewBase
{
	[HideInInspector]
	public string _ID;

	[HideInInspector]
	public long _President;

	[HideInInspector]
	public string _Name;

	[HideInInspector]
	public string _Slogan;

	[HideInInspector]
	public string _Notice;

	[HideInInspector]
	public int _Liveness;

	[HideInInspector]
	public string _IsSilent;

	[HideInInspector]
	public long _RecallTime;

	[HideInInspector]
	public long _RecallMember;

	[HideInInspector]
	public string _Emblem;

	[HideInInspector]
	public int _Privilege;

	[HideInInspector]
	public int _OperationResult;

	[HideInInspector]
	public int _Vitalities;

	[HideInInspector]
	public int _DonateTime;

	[HideInInspector]
	public string _EmblemBorder;

	[HideInInspector]
	public string _EmblemBackground;

	[HideInInspector]
	public int _TotalVitality;

	[HideInInspector]
	public int _DailyVitality;

	[HideInInspector]
	public int _emblemColor;

	[HideInInspector]
	public int _emblemborderColor;

	[HideInInspector]
	public int _emblembackgroundColor;

	[HideInInspector]
	public long _CombatEffectiveness;

	[HideInInspector]
	public int _RequestUserNum;

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

	public GuildManagerViewModel GuildManager
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

	public virtual void ExecuteOperateGuild(GuildOpArgu arg)
	{
	}

	public virtual void ExecuteFinishOperation()
	{
	}

	public virtual void ExecuteRefreshGuildInfo()
	{
	}

	public virtual void ExecuteSyncAfterDismiss()
	{
	}

	public virtual void ExecuteFinishSyncAfterDismiss()
	{
	}

	public virtual void ExecuteSyncMember()
	{
	}

	public virtual void ExecuteAfterSyncMember()
	{
	}

	public virtual void ExecuteSyncRequest()
	{
	}

	public virtual void ExecuteAfterSyncRequest()
	{
	}
}
