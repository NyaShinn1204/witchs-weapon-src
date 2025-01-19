public class PackageItemViewModelBase : ViewModel
{
	public P<long> _IDProperty;

	public P<string> _NameProperty;

	public P<long> _NumProperty;

	public P<PackageItemDetail> _DetailProperty;

	public PackageItemViewModelBase(PackageItemControllerBase controller, bool initialize = true)
	{
	}

	public PackageItemViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
