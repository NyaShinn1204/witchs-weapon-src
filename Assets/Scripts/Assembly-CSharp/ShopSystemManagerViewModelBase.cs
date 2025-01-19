public class ShopSystemManagerViewModelBase : ViewModel
{
	public P<string> _BuyResultProperty;

	public P<string> _PayResultProperty;

	public ModelCollection<ShopSet> _AllShopSetsProperty;

	public ModelCollection<DrawResultData> _BuyLootsProperty;

	public ModelCollection<DrawResultData> _ExtraWeaponProperty;

	protected CommandWithSenderAndArgument<ShopSystemManagerViewModel, long> _ManulRefresh;

	protected CommandWithSenderAndArgument<ShopSystemManagerViewModel, string> _RefreshOutofDateShopSet;

	protected CommandWithSender<ShopSystemManagerViewModel> _FinishRefresh;

	protected CommandWithSenderAndArgument<ShopSystemManagerViewModel, BuyGoodArug> _BuyGood;

	protected CommandWithSender<ShopSystemManagerViewModel> _FinishBuyGood;

	protected CommandWithSender<ShopSystemManagerViewModel> _FinishPay;

	protected CommandWithSenderAndArgument<ShopSystemManagerViewModel, BuyGoodArug> _CreatePay;

	protected CommandWithSenderAndArgument<ShopSystemManagerViewModel, string> _RefreshManagerShopSet;

	public ShopSystemManagerViewModelBase(ShopSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public ShopSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
