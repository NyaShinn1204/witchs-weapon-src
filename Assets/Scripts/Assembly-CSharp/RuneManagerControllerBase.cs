public abstract class RuneManagerControllerBase : Controller
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

	[Inject]
	public RuneItemController RuneItemController { get; set; }

	public abstract void InitializeRuneManager(RuneManagerViewModel runeManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual RuneManagerViewModel CreateRuneManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void Dentify(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void DentifyConfirm(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void Lock(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void Mount(RuneManagerViewModel runeManager, RuneMountArgu arg)
	{
	}

	public virtual void AddExp(RuneManagerViewModel runeManager, RuneArgument arg)
	{
	}

	public virtual void BreakThrough(RuneManagerViewModel runeManager, RuneArgument arg)
	{
	}

	public virtual void Promote(RuneManagerViewModel runeManager, RuneArgument arg)
	{
	}

	public virtual void Resolve(RuneManagerViewModel runeManager, string arg)
	{
	}

	public virtual void Unlock(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void UnMount(RuneManagerViewModel runeManager, RuneMountArgu arg)
	{
	}

	public virtual void MountAll(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void UnMountAll(RuneManagerViewModel runeManager, long arg)
	{
	}

	public virtual void ResolveAll(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishResolve(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishResolveAll(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishDentify(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishDentifyConfrim(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishAddExp(RuneManagerViewModel runeManager)
	{
	}

	public virtual void FinishBreak(RuneManagerViewModel runeManager)
	{
	}
}
