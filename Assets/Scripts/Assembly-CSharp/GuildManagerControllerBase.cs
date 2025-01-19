public abstract class GuildManagerControllerBase : Controller
{
	[Inject]
	public MainSceneGlobalManagerViewModel MainSceneGlobalManager { get; set; }

	[Inject]
	public UserPlayerManagerViewModel UserPlayerManager { get; set; }

	[Inject]
	public UserAchievementManagerViewModel UserAchievementManager { get; set; }

	[Inject]
	public DrawSystemManagerViewModel DrawSystemManager { get; set; }

	[Inject]
	public PurchaseSystemManagerViewModel PurchaseSystemManager { get; set; }

	[Inject]
	public MailManagerViewModel MailManager { get; set; }

	[Inject]
	public ExpeditionManagerViewModel ExpeditionManager { get; set; }

	[Inject]
	public ServantListManagerViewModel ServantCore { get; set; }

	[Inject]
	public SingleServantViewModel SingleServant { get; set; }

	[Inject]
	public CurrentServantWeaponInfoViewModel CurrentServantWeaponInfo { get; set; }

	[Inject]
	public CurrentServantStarInfoViewModel CurrentServantStarInfo { get; set; }

	[Inject]
	public PackageManagerViewModel PackageManager { get; set; }

	[Inject]
	public RuneManagerViewModel RuneManager { get; set; }

	[Inject]
	public ProgressSystemManagerViewModel ProgressSystemManager { get; set; }

	[Inject]
	public CurrentLevelDetailViewModel CurrentLevelDetail { get; set; }

	[Inject]
	public AchievementSystemManagerViewModel AchievementSystemManager { get; set; }

	[Inject]
	public QuestSystemManagerViewModel QuestSystemManager { get; set; }

	[Inject]
	public ShopSystemManagerViewModel ShopSystemManager { get; set; }

	[Inject]
	public PhoneReminderSystemManagerViewModel PhoneReminderSystemManager { get; set; }

	[Inject]
	public GuildUserManagerViewModel GuildUserManager { get; set; }

	[Inject]
	public GuildManagerViewModel GuildManager { get; set; }

	[Inject]
	public GuildMercenaryManagerViewModel GuildMercenaryManager { get; set; }

	[Inject]
	public FashionSystemManagerViewModel FashionSystemManager { get; set; }

	[Inject]
	public ActivityPlaySystemManagerViewModel ActivityPlaySystemManager { get; set; }

	[Inject]
	public StorySystemManagerViewModel StorySystemManager { get; set; }

	public abstract void InitializeGuildManager(GuildManagerViewModel guildManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual GuildManagerViewModel CreateGuildManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void OperateGuild(GuildManagerViewModel guildManager, GuildOpArgu arg)
	{
	}

	public virtual void FinishOperation(GuildManagerViewModel guildManager)
	{
	}

	public virtual void RefreshGuildInfo(GuildManagerViewModel guildManager)
	{
	}

	public virtual void SyncAfterDismiss(GuildManagerViewModel guildManager)
	{
	}

	public virtual void FinishSyncAfterDismiss(GuildManagerViewModel guildManager)
	{
	}

	public virtual void SyncMember(GuildManagerViewModel guildManager)
	{
	}

	public virtual void AfterSyncMember(GuildManagerViewModel guildManager)
	{
	}

	public virtual void SyncRequest(GuildManagerViewModel guildManager)
	{
	}

	public virtual void AfterSyncRequest(GuildManagerViewModel guildManager)
	{
	}
}
