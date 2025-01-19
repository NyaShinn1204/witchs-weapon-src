public class GuildMercenaryManagerViewModelBase : ViewModel
{
	public P<int> _MaxSvNumProperty;

	public P<int> _OpResultProperty;

	public P<int> _ModeProperty;

	public P<long> _RemoveMercenaryRewardProperty;

	public P<long> _RemoveMecGoldRewardProperty;

	public ModelCollection<GuildMercenarySv> _ServantsProperty;

	public ModelCollection<GuildMercenarySv> _OwnServantsProperty;

	public ModelCollection<int> _MercenaryRewardsProperty;

	protected CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, AddSvArgu> _AddSv;

	protected CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, long> _RemoveSv;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FreshMercenariesList;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishFresh;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishAdd;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishRemove;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FreshCanHireList;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishFreshCanHireList;

	protected CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, SelectSvGroup> _SelectBattleGroup;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishSelectBattleGroup;

	protected CommandWithSenderAndArgument<GuildMercenaryManagerViewModel, SelectSvGroup> _HireMercenary;

	protected CommandWithSender<GuildMercenaryManagerViewModel> _FinishHireMercenary;

	public GuildMercenaryManagerViewModelBase(GuildMercenaryManagerControllerBase controller, bool initialize = true)
	{
	}

	public GuildMercenaryManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
