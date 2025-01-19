using System;
using UnityEngine;

public abstract class PackageManagerViewBase : ViewBase
{
	[HideInInspector]
	public ViewBase _ItemToRefresh;

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

	public PackageManagerViewModel PackageManager
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

	public virtual void ExecuteAddItemByID(long arg)
	{
	}

	public virtual void ExecuteRemoveItemById(long arg)
	{
	}

	public virtual void ExecuteChangeItem(string arg)
	{
	}

	public virtual void ExecuteSellItem(SellArgument arg)
	{
	}

	public virtual void ExecuteUseItem(SellArgument arg)
	{
	}

	public virtual void ExecuteUseSpStamina(UseItemArgus arg)
	{
	}

	public virtual void ExecuteGetRecycleShop()
	{
	}

	public virtual void ExecuteFinishGetRecycleShop()
	{
	}

	public virtual void ExecuteSellRecycleItems(string arg)
	{
	}

	public virtual void ExecuteFinishSellRecycleItems()
	{
	}

	public virtual void ExecuteSellAllRecycle()
	{
	}

	public virtual void ExecuteFinishSellAllRecycle()
	{
	}

	public virtual void ExecuteOpenChest(SellArgument arg)
	{
	}

	public virtual void ExecuteFinishOpenChest()
	{
	}
}
