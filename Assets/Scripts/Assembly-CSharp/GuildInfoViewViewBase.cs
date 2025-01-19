using UnityEngine;

public class GuildInfoViewViewBase : GuildManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishOperation;

	[HideInInspector]
	public bool _BindPrivilege;

	[HideInInspector]
	public bool _BindNotice;

	[HideInInspector]
	public bool _BindID;

	[HideInInspector]
	public bool _BindRefreshGuildInfo;

	[HideInInspector]
	public bool _BindFinishSyncAfterDismiss;

	[HideInInspector]
	public bool _BindAfterSyncMember;

	[HideInInspector]
	public bool _BindAfterSyncRequest;

	[HideInInspector]
	public bool _BindRequestUserNum;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishOperationExecuted()
	{
	}

	public virtual void PrivilegeChanged(int value)
	{
	}

	public virtual void NoticeChanged(string value)
	{
	}

	public virtual void IDChanged(string value)
	{
	}

	public virtual void RefreshGuildInfoExecuted()
	{
	}

	public virtual void FinishSyncAfterDismissExecuted()
	{
	}

	public virtual void AfterSyncMemberExecuted()
	{
	}

	public virtual void AfterSyncRequestExecuted()
	{
	}

	public virtual void RequestUserNumChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
