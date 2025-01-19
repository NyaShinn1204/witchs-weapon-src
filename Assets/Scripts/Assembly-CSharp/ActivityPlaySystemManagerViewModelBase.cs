public class ActivityPlaySystemManagerViewModelBase : ViewModel
{
	public P<bool> _IsOpenProperty;

	public P<bool> _IsReceiveInitStaminaProperty;

	public P<bool> _IsReceiveDailyStaminaProperty;

	public P<long> _CurrencyProperty;

	public P<long> _ActivityStaminaProperty;

	public P<bool> _UnlockStoryProperty;

	public P<bool> _ActOpenProperty;

	public P<long> _TicketProperty;

	public P<int> _FightCountProperty;

	public P<int> _SweepResultProperty;

	public P<long> _Currency2Property;

	public ModelCollection<DrawResultData> _DrawLootProperty;

	public ModelCollection<DrawResultData> _ExtraWeaponProperty;

	public ModelCollection<DrawResultData> _ExtraBonusProperty;

	public ModelCollection<long> _LootBuffProperty;

	public ModelCollection<int> _LootBuffLayerProperty;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _ReceiveInitStamina;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _ReceiveDailyStamina;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> _Reset;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _GetReward;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishGetRewaed;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishReset;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _UnlockAPStory;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> _GetRank;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishGetRank;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, SweepArgu> _Sweep;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishSweep;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _GoToNextFloorRule1;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishGoToNextFloorRule1;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, string> _AttributeAdd;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishAttributeAdd;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _AttributeReset;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishAttributeReset;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> _Rule5Reset;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> _Rule5GiveUp;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> _Rule5Getreward;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishRule5Reset;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishRule5GiveUp;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishRule5Getreward;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> _Rule5UnlockFinalRound;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, ChangeKeyArg> _ChangeKey;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishRule5UnlockFinalRound;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishChangeKey;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, int> _R4ChooseMobLevel;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishR4ChooseMobLevel;

	protected CommandWithSenderAndArgument<ActivityPlaySystemManagerViewModel, Rule5Argu> _R5ChooseMobLevel;

	protected CommandWithSender<ActivityPlaySystemManagerViewModel> _FinishR5ChooseMobLevel;

	public ActivityPlaySystemManagerViewModelBase(ActivityPlaySystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public ActivityPlaySystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
