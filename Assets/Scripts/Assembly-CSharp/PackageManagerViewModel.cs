using System.Collections.Generic;
using System.Collections.Specialized;

public class PackageManagerViewModel : PackageManagerViewModelBase
{
	public virtual P<PackageItemViewModel> ItemToRefreshProperty
	{
		get
		{
			return null;
		}
	}

	public virtual PackageItemViewModel ItemToRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ModelCollection<PackageItemViewModel> AllBag
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, long> AddItemByID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, long> RemoveItemById
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, string> ChangeItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> SellItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> UseItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, UseItemArgus> UseSpStamina
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> GetRecycleShop
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> FinishGetRecycleShop
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, string> SellRecycleItems
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> FinishSellRecycleItems
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> SellAllRecycle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> FinishSellAllRecycle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> OpenChest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PackageManagerViewModel> FinishOpenChest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PackageManagerViewModel(PackageManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public PackageManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}

	protected override void AllBagCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
