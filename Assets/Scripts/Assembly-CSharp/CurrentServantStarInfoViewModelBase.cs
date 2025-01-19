public class CurrentServantStarInfoViewModelBase : ViewModel
{
	public P<long> _StarInfoIDProperty;

	public P<NeedLoot> _NeedItemProperty;

	public P<int> _ItemNumProperty;

	public P<int> _StarLevelProperty;

	public P<int> _CostProperty;

	protected CommandWithSenderAndArgument<CurrentServantStarInfoViewModel, int> _AddStarPoint;

	protected CommandWithSender<CurrentServantStarInfoViewModel> _AddStartLv;

	public CurrentServantStarInfoViewModelBase(CurrentServantStarInfoControllerBase controller, bool initialize = true)
	{
	}

	public CurrentServantStarInfoViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
