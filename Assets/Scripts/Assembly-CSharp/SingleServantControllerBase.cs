public abstract class SingleServantControllerBase : Controller
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

	public abstract void InitializeSingleServant(SingleServantViewModel singleServant);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual SingleServantViewModel CreateSingleServant()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void GotoPreServant(SingleServantViewModel singleServant)
	{
	}

	public virtual void GotoNextServant(SingleServantViewModel singleServant)
	{
	}

	public virtual void AddRank(SingleServantViewModel singleServant)
	{
	}

	public virtual void AddSpellActiveLevel(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void AddSpellPassiveLevel1(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void AddSpellPassiveLevel2(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void AddSpellPassiveLevel3(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void EquipAll(SingleServantViewModel singleServant)
	{
	}

	public virtual void UseEuip(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void AddExp(SingleServantViewModel singleServant, UseItemArgus arg)
	{
	}

	public virtual void ComposeEquip(SingleServantViewModel singleServant, long arg)
	{
	}

	public virtual void ComposeEquipOneClick(SingleServantViewModel singleServant, long arg)
	{
	}

	public virtual void ChangeImage(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void ReceiveImageFav(SingleServantViewModel singleServant, int arg)
	{
	}

	public virtual void FinishFavQuest(SingleServantViewModel singleServant)
	{
	}
}
