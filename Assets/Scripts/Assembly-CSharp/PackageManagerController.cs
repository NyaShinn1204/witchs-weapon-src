using WaterBell.ProjX.Data.Entity;

public class PackageManagerController : PackageManagerControllerBase
{
	private SellArgument OpenChestArgument;

	public override void InitializePackageManager(PackageManagerViewModel packageManager)
	{
	}

	private bool IsNeedToDisplay(long ID)
	{
		return false;
	}

	private void AddItem(ObservableSingleItem item)
	{
	}

	private void RemoveItem(ObservableSingleItem item)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	public override void AddItemByID(PackageManagerViewModel packageManager, long arg)
	{
	}

	public override void ChangeItem(PackageManagerViewModel packageManager, string arg)
	{
	}

	public override void RemoveItemById(PackageManagerViewModel packageManager, long arg)
	{
	}

	public override void SellItem(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	public override void UseItem(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	public override void OpenChest(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	private void AfterOpenChest()
	{
	}

	public override void UseSpStamina(PackageManagerViewModel packageManager, UseItemArgus arg)
	{
	}

	public override void GetRecycleShop(PackageManagerViewModel packageManager)
	{
	}

	private void SuccessGetCycleShopInfo()
	{
	}

	public override void SellAllRecycle(PackageManagerViewModel packageManager)
	{
	}

	private void SuccessSellAllRecycle()
	{
	}

	public override void SellRecycleItems(PackageManagerViewModel packageManager, string arg)
	{
	}

	private void SuccessSellRecycleItems()
	{
	}
}
