using System;
using UnityEngine;

public abstract class ShopSystemManagerViewBase : ViewBase
{
	[HideInInspector]
	public string _BuyResult;

	[HideInInspector]
	public string _PayResult;

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

	public ShopSystemManagerViewModel ShopSystemManager
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

	public virtual void ExecuteManulRefresh(long arg)
	{
	}

	public virtual void ExecuteRefreshOutofDateShopSet(string arg)
	{
	}

	public virtual void ExecuteFinishRefresh()
	{
	}

	public virtual void ExecuteBuyGood(BuyGoodArug arg)
	{
	}

	public virtual void ExecuteFinishBuyGood()
	{
	}

	public virtual void ExecuteFinishPay()
	{
	}

	public virtual void ExecuteCreatePay(BuyGoodArug arg)
	{
	}

	public virtual void ExecuteRefreshManagerShopSet(string arg)
	{
	}
}
