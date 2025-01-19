using System;
using UnityEngine;

public abstract class UserPlayerManagerViewBase : ViewBase
{
	[HideInInspector]
	public string _RoleID;

	[HideInInspector]
	public long _Gold;

	[HideInInspector]
	public int _Level;

	[HideInInspector]
	public long _Exp;

	[HideInInspector]
	public int _Vit;

	[HideInInspector]
	public int _Vip;

	[HideInInspector]
	public long _Vittime;

	[HideInInspector]
	public int _FreeGoldDraw;

	[HideInInspector]
	public int _FreeRMBDraw;

	[HideInInspector]
	public int _BuyVitTime;

	[HideInInspector]
	public int _BuyGoldTime;

	[HideInInspector]
	public long _RMB;

	[HideInInspector]
	public int _ExpdeditionTime;

	[HideInInspector]
	public int _ReceiveStaminaResult;

	[HideInInspector]
	public int _Head;

	[HideInInspector]
	public int _HeadBox;

	[HideInInspector]
	public int _VipExp;

	[HideInInspector]
	public int _VipPoint;

	[HideInInspector]
	public bool _Vip2GiftState;

	[HideInInspector]
	public bool _Vip5GiftState;

	[HideInInspector]
	public int _StoryCurrency;

	[HideInInspector]
	public int _ActivityStoryCurrency;

	[HideInInspector]
	public int _DrawCurrency;

	[HideInInspector]
	public bool _SecretShop1State;

	[HideInInspector]
	public bool _SecretShop2State;

	[HideInInspector]
	public int _RenameItemNum;

	[HideInInspector]
	public int _RenameResult;

	[HideInInspector]
	public int _RedeemResult;

	[HideInInspector]
	public bool _isSpecialRCode;

	[HideInInspector]
	public int _FashionItemNum;

	[HideInInspector]
	public bool _CanReceiveStamina;

	[HideInInspector]
	public bool _isReceivePhoneReward;

	[HideInInspector]
	public int _RecycleCurrency;

	[HideInInspector]
	public long _InviteOpResult;

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

	public UserPlayerManagerViewModel UserPlayerManager
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

	public virtual void ExecuteReceiveStamina()
	{
	}

	public virtual void ExecuteFinishReceiveStamina()
	{
	}

	public virtual void ExecuteChangeCurrentHead(int arg)
	{
	}

	public virtual void ExecuteChangeCurrentHeadBox(int arg)
	{
	}

	public virtual void ExecuteChangeHeadAndBox(string arg)
	{
	}

	public virtual void ExecuteReceiveVip2Gift()
	{
	}

	public virtual void ExecuteReceiveVip5Gift()
	{
	}

	public virtual void ExecuteFinishReceiveGift()
	{
	}

	public virtual void ExecuteChangeCurrentSvAction(long arg)
	{
	}

	public virtual void ExecuteReName(string arg)
	{
	}

	public virtual void ExecuteFinishReName()
	{
	}

	public virtual void ExecuteChangeTitle(long arg)
	{
	}

	public virtual void ExecuteRedeem(string arg)
	{
	}

	public virtual void ExecuteFinishRedeem()
	{
	}

	public virtual void ExecuteReceivePhoneReward()
	{
	}

	public virtual void ExecuteReceiveInviteReward(long arg)
	{
	}

	public virtual void ExecuteFinishReceiveInviteReward()
	{
	}

	public virtual void ExecuteReceiveBeInvitedReward(long arg)
	{
	}

	public virtual void ExecuteFinishReceiveBeInvitedReward()
	{
	}

	public virtual void ExecuteUseInviteCode(long arg)
	{
	}

	public virtual void ExecuteFinishUseInviteCode()
	{
	}

	public virtual void ExecuteSyncInviteInfo()
	{
	}

	public virtual void ExecuteFinishSyncInviteInfo()
	{
	}
}
