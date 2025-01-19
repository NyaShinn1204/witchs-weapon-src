public abstract class GuildUserManagerControllerBase : Controller
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

	public abstract void InitializeGuildUserManager(GuildUserManagerViewModel guildUserManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual GuildUserManagerViewModel CreateGuildUserManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void SearchGuild(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	public virtual void RequestGuild(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	public virtual void CancelRequest(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	public virtual void CreateGuild(GuildUserManagerViewModel guildUserManager, GuildCreateArgu arg)
	{
	}

	public virtual void FinishSearch(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void FinishCreate(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void FinishRequest(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void FinishCancel(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void Synchronize(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void FinishSynchronize(GuildUserManagerViewModel guildUserManager)
	{
	}

	public virtual void GetAllGuild(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}

	public virtual void SearchGuildByCE(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}

	public virtual void SearchGuildByMember(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}
}
