public class PurchaseSystemManagerViewModelBase : ViewModel
{
	public P<bool> _BuyGoldSignalProperty;

	public P<int> _MultProperty;

	public P<long> _RMBProperty;

	public P<int> _VitNowProperty;

	public P<int> _VitTimeProperty;

	public P<string> _BuyGoldResultProperty;

	public P<bool> _BuyVitSignalProperty;

	public P<string> _BuyVitResultProperty;

	public P<long> _GoldProperty;

	protected CommandWithSender<PurchaseSystemManagerViewModel> _BuyGold;

	protected CommandWithSender<PurchaseSystemManagerViewModel> _BuyVit;

	public PurchaseSystemManagerViewModelBase(PurchaseSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public PurchaseSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
