public class GuildUserManagerViewModelBase : ViewModel
{
	public P<bool> _isOpenProperty;

	public P<long> _LastTimeLeaveGuildProperty;

	public P<int> _GuildOpResultProperty;

	public P<GuildStateEnum> _StateProperty;

	public P<long> _GuildCurrencyProperty;

	public P<int> _GuildListPageNumProperty;

	public ModelCollection<GuildSimple> _GuildRequestListProperty;

	public ModelCollection<GuildSimple> _CacheGuildListProperty;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, string> _SearchGuild;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, string> _RequestGuild;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, string> _CancelRequest;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, GuildCreateArgu> _CreateGuild;

	protected CommandWithSender<GuildUserManagerViewModel> _FinishSearch;

	protected CommandWithSender<GuildUserManagerViewModel> _FinishCreate;

	protected CommandWithSender<GuildUserManagerViewModel> _FinishRequest;

	protected CommandWithSender<GuildUserManagerViewModel> _FinishCancel;

	protected CommandWithSender<GuildUserManagerViewModel> _Synchronize;

	protected CommandWithSender<GuildUserManagerViewModel> _FinishSynchronize;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, int> _GetAllGuild;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, int> _SearchGuildByCE;

	protected CommandWithSenderAndArgument<GuildUserManagerViewModel, int> _SearchGuildByMember;

	public GuildUserManagerViewModelBase(GuildUserManagerControllerBase controller, bool initialize = true)
	{
	}

	public GuildUserManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
