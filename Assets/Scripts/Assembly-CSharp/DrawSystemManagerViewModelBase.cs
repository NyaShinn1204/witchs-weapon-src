public class DrawSystemManagerViewModelBase : ViewModel
{
	public P<int> _DrawTypeProperty;

	public P<int> _DrawResultProperty;

	public P<int> _RemainFreeGoldTimeProperty;

	public P<int> _RemainFreeRMBTimeProperty;

	public P<bool> _HaveFreeDrawProperty;

	public P<int> _GiftCouponNumProperty;

	public P<long> _ActIDProperty;

	public ModelCollection<DrawResultData> _DrawLootProperty;

	public ModelCollection<DrawResultData> _ExtraWeaponProperty;

	protected CommandWithSenderAndArgument<DrawSystemManagerViewModel, DrawArgu> _Draw;

	protected CommandWithSender<DrawSystemManagerViewModel> _DrawFinish;

	public DrawSystemManagerViewModelBase(DrawSystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public DrawSystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
