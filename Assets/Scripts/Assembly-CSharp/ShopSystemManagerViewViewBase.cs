using UnityEngine;

public class ShopSystemManagerViewViewBase : ShopSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindManulRefresh;

	[HideInInspector]
	public bool _BindRefreshOutofDateShopSet;

	[HideInInspector]
	public bool _BindFinishRefresh;

	[HideInInspector]
	public bool _BindFinishPay;

	[HideInInspector]
	public bool _BindFinishBuyGood;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ManulRefreshExecuted()
	{
	}

	public virtual void RefreshOutofDateShopSetExecuted()
	{
	}

	public virtual void FinishRefreshExecuted()
	{
	}

	public virtual void FinishPayExecuted()
	{
	}

	public virtual void FinishBuyGoodExecuted()
	{
	}

	public override void Bind()
	{
	}
}
