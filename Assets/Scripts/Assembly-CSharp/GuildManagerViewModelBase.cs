public class GuildManagerViewModelBase : ViewModel
{
	public P<string> _IDProperty;

	public P<long> _PresidentProperty;

	public P<string> _NameProperty;

	public P<string> _SloganProperty;

	public P<string> _NoticeProperty;

	public P<int> _LivenessProperty;

	public P<string> _IsSilentProperty;

	public P<long> _RecallTimeProperty;

	public P<long> _RecallMemberProperty;

	public P<string> _EmblemProperty;

	public P<int> _PrivilegeProperty;

	public P<GuildOpArgu> _OperationArguProperty;

	public P<int> _OperationResultProperty;

	public P<int> _VitalitiesProperty;

	public P<int> _DonateTimeProperty;

	public P<string> _EmblemBorderProperty;

	public P<string> _EmblemBackgroundProperty;

	public P<int> _TotalVitalityProperty;

	public P<int> _DailyVitalityProperty;

	public P<int> _emblemColorProperty;

	public P<int> _emblemborderColorProperty;

	public P<int> _emblembackgroundColorProperty;

	public P<long> _CombatEffectivenessProperty;

	public P<int> _RequestUserNumProperty;

	public ModelCollection<RequestMember> _RequestUsersProperty;

	public ModelCollection<GuildMember> _GuildMemberProperty;

	public ModelCollection<long> _AdminsProperty;

	protected CommandWithSenderAndArgument<GuildManagerViewModel, GuildOpArgu> _OperateGuild;

	protected CommandWithSender<GuildManagerViewModel> _FinishOperation;

	protected CommandWithSender<GuildManagerViewModel> _RefreshGuildInfo;

	protected CommandWithSender<GuildManagerViewModel> _SyncAfterDismiss;

	protected CommandWithSender<GuildManagerViewModel> _FinishSyncAfterDismiss;

	protected CommandWithSender<GuildManagerViewModel> _SyncMember;

	protected CommandWithSender<GuildManagerViewModel> _AfterSyncMember;

	protected CommandWithSender<GuildManagerViewModel> _SyncRequest;

	protected CommandWithSender<GuildManagerViewModel> _AfterSyncRequest;

	public GuildManagerViewModelBase(GuildManagerControllerBase controller, bool initialize = true)
	{
	}

	public GuildManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
