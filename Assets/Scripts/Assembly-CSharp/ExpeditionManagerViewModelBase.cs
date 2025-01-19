public class ExpeditionManagerViewModelBase : ViewModel
{
	public P<int> _CurrentIndexProperty;

	public P<int> _ResetResultProperty;

	public P<int> _ReceiveChestResultProperty;

	public P<long> _ChestGoldProperty;

	public P<int> _hpProperty;

	public P<int> _EnterCountProperty;

	public P<bool> _IsOpenProperty;

	public P<int> _CscCurrencyProperty;

	public ModelCollection<ExpeditionServant> _ServantsProperty;

	public ModelCollection<ExpeditionProgressInfo> _ExpeditionInfoProperty;

	public ModelCollection<DrawResultData> _ReceiveLootsProperty;

	public ModelCollection<long> _SelectedServantsProperty;

	protected CommandWithSender<ExpeditionManagerViewModel> _ResetExpedition;

	protected CommandWithSenderAndArgument<ExpeditionManagerViewModel, CommitExpeditionServant> _CommitExpeditionServant;

	protected CommandWithSender<ExpeditionManagerViewModel> _ReceiveChest;

	protected CommandWithSender<ExpeditionManagerViewModel> _RefreshExpedition;

	protected CommandWithSender<ExpeditionManagerViewModel> _FinishReset;

	protected CommandWithSender<ExpeditionManagerViewModel> _FinishLoot;

	protected CommandWithSenderAndArgument<ExpeditionManagerViewModel, int> _GetRank;

	protected CommandWithSender<ExpeditionManagerViewModel> _FinishGetRank;

	public ExpeditionManagerViewModelBase(ExpeditionManagerControllerBase controller, bool initialize = true)
	{
	}

	public ExpeditionManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
