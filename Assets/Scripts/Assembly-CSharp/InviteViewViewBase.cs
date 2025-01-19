using UnityEngine;

public class InviteViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishUseInviteCode;

	[HideInInspector]
	public bool _BindFinishReceiveBeInvitedReward;

	[HideInInspector]
	public bool _BindFinishReceiveInviteReward;

	[HideInInspector]
	public bool _BindFinishSyncInviteInfo;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishUseInviteCodeExecuted()
	{
	}

	public virtual void FinishReceiveBeInvitedRewardExecuted()
	{
	}

	public virtual void FinishReceiveInviteRewardExecuted()
	{
	}

	public virtual void FinishSyncInviteInfoExecuted()
	{
	}

	public override void Bind()
	{
	}
}
