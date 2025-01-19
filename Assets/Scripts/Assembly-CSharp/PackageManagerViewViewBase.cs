using UnityEngine;

public class PackageManagerViewViewBase : PackageManagerViewBase
{
	[HideInInspector]
	public bool _BindSellItem;

	[HideInInspector]
	public bool _BindItemToRefresh;

	[HideInInspector]
	public bool _BindAllBag;

	[HideInInspector]
	public bool _BindUseItem;

	[HideInInspector]
	public bool _BindFinishOpenChest;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SellItemExecuted()
	{
	}

	public virtual void ItemToRefreshChanged(PackageItemViewModel value)
	{
	}

	public virtual void AllBagAdded(PackageItemViewModel item)
	{
	}

	public virtual void AllBagRemoved(PackageItemViewModel item)
	{
	}

	public virtual void UseItemExecuted()
	{
	}

	public virtual void FinishOpenChestExecuted()
	{
	}

	public override void Bind()
	{
	}
}
