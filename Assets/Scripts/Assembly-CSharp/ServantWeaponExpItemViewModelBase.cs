public class ServantWeaponExpItemViewModelBase : ViewModel
{
	public P<long> _IDProperty;

	public P<int> _NumProperty;

	public P<PackageItemDetail> _InfoProperty;

	public ServantWeaponExpItemViewModelBase(ServantWeaponExpItemControllerBase controller, bool initialize = true)
	{
	}

	public ServantWeaponExpItemViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
