using UnityEngine;

public class RecycleViewViewBase : PackageManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishGetRecycleShop;

	[HideInInspector]
	public bool _BindFinishSellRecycleItems;

	[HideInInspector]
	public bool _BindFinishSellAllRecycle;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishGetRecycleShopExecuted()
	{
	}

	public virtual void FinishSellRecycleItemsExecuted()
	{
	}

	public virtual void FinishSellAllRecycleExecuted()
	{
	}

	public override void Bind()
	{
	}
}
