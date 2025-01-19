using UnityEngine;

public class UserPlayerManagerViewViewBase : UserPlayerManagerViewBase
{
	[HideInInspector]
	public bool _BindVit;

	[HideInInspector]
	public bool _BindGold;

	[HideInInspector]
	public bool _BindRMB;

	[HideInInspector]
	public bool _BindChangeHeadAndBox;

	[HideInInspector]
	public bool _BindDrawCurrency;

	[HideInInspector]
	public bool _BindFinishReName;

	[HideInInspector]
	public bool _BindChangeTitle;

	[HideInInspector]
	public bool _BindFinishRedeem;

	[HideInInspector]
	public bool _BindFashionItemNum;

	[HideInInspector]
	public bool _BindStoryCurrency;

	[HideInInspector]
	public bool _BindActivityStoryCurrency;

	[HideInInspector]
	public bool _BindisReceivePhoneReward;

	[HideInInspector]
	public bool _BindRecycleCurrency;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void VitChanged(int value)
	{
	}

	public virtual void GoldChanged(long value)
	{
	}

	public virtual void RMBChanged(long value)
	{
	}

	public virtual void ChangeHeadAndBoxExecuted()
	{
	}

	public virtual void DrawCurrencyChanged(int value)
	{
	}

	public virtual void FinishReNameExecuted()
	{
	}

	public virtual void ChangeTitleExecuted()
	{
	}

	public virtual void FinishRedeemExecuted()
	{
	}

	public virtual void FashionItemNumChanged(int value)
	{
	}

	public virtual void StoryCurrencyChanged(int value)
	{
	}

	public virtual void ActivityStoryCurrencyChanged(int value)
	{
	}

	public virtual void isReceivePhoneRewardChanged(bool value)
	{
	}

	public virtual void RecycleCurrencyChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
