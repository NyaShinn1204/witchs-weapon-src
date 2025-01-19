using UnityEngine;

public class UserPlayerHeadIconViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindLevel;

	[HideInInspector]
	public bool _BindExp;

	[HideInInspector]
	public bool _BindSecretShop1State;

	[HideInInspector]
	public bool _BindSecretShop2State;

	[HideInInspector]
	public bool _BindFinishSyncInviteInfo;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void LevelChanged(int value)
	{
	}

	public virtual void ExpChanged(long value)
	{
	}

	public virtual void SecretShop1StateChanged(bool value)
	{
	}

	public virtual void SecretShop2StateChanged(bool value)
	{
	}

	public virtual void FinishSyncInviteInfoExecuted()
	{
	}

	public override void Bind()
	{
	}
}
