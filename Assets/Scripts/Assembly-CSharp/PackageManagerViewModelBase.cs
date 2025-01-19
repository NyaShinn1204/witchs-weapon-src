using System.Collections.Specialized;

public class PackageManagerViewModelBase : ViewModel
{
	public P<PackageItemViewModel> _ItemToRefreshProperty;

	public ModelCollection<PackageItemViewModel> _AllBagProperty;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, long> _AddItemByID;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, long> _RemoveItemById;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, string> _ChangeItem;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> _SellItem;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> _UseItem;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, UseItemArgus> _UseSpStamina;

	protected CommandWithSender<PackageManagerViewModel> _GetRecycleShop;

	protected CommandWithSender<PackageManagerViewModel> _FinishGetRecycleShop;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, string> _SellRecycleItems;

	protected CommandWithSender<PackageManagerViewModel> _FinishSellRecycleItems;

	protected CommandWithSender<PackageManagerViewModel> _SellAllRecycle;

	protected CommandWithSender<PackageManagerViewModel> _FinishSellAllRecycle;

	protected CommandWithSenderAndArgument<PackageManagerViewModel, SellArgument> _OpenChest;

	protected CommandWithSender<PackageManagerViewModel> _FinishOpenChest;

	public PackageManagerViewModelBase(PackageManagerControllerBase controller, bool initialize = true)
	{
	}

	public PackageManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void AllBagCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
