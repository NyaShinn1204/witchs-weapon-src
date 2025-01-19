public class FashionSystemManagerViewModelBase : ViewModel
{
	public P<FashionInfo> _CurrentFashionProperty;

	public ModelCollection<FashionInfo> _FashionsProperty;

	protected CommandWithSenderAndArgument<FashionSystemManagerViewModel, long> _SelectFashion;

	protected CommandWithSenderAndArgument<FashionSystemManagerViewModel, long> _BuyFashion;

	protected CommandWithSender<FashionSystemManagerViewModel> _RefreshFashion;

	protected CommandWithSender<FashionSystemManagerViewModel> _FinishRefresh;

	public FashionSystemManagerViewModelBase(FashionSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public FashionSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
