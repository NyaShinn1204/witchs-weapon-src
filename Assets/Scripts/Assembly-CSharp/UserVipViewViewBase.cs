using UnityEngine;

public class UserVipViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishReceiveGift;

	[HideInInspector]
	public bool _BindVip;

	[HideInInspector]
	public bool _BindVipExp;

	[HideInInspector]
	public bool _BindVipPoint;

	[HideInInspector]
	public bool _BindVip2GiftState;

	[HideInInspector]
	public bool _BindVip5GiftState;

	[HideInInspector]
	public bool _BindCanReceiveStamina;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishReceiveGiftExecuted()
	{
	}

	public virtual void VipChanged(int value)
	{
	}

	public virtual void VipExpChanged(int value)
	{
	}

	public virtual void VipPointChanged(int value)
	{
	}

	public virtual void Vip2GiftStateChanged(bool value)
	{
	}

	public virtual void Vip5GiftStateChanged(bool value)
	{
	}

	public virtual void CanReceiveStaminaChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
