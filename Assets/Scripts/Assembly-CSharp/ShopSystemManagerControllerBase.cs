public abstract class ShopSystemManagerControllerBase : Controller
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

	public abstract void InitializeShopSystemManager(ShopSystemManagerViewModel shopSystemManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual ShopSystemManagerViewModel CreateShopSystemManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void ManulRefresh(ShopSystemManagerViewModel shopSystemManager, long arg)
	{
	}

	public virtual void RefreshOutofDateShopSet(ShopSystemManagerViewModel shopSystemManager, string arg)
	{
	}

	public virtual void FinishRefresh(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	public virtual void BuyGood(ShopSystemManagerViewModel shopSystemManager, BuyGoodArug arg)
	{
	}

	public virtual void FinishBuyGood(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	public virtual void FinishPay(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	public virtual void CreatePay(ShopSystemManagerViewModel shopSystemManager, BuyGoodArug arg)
	{
	}

	public virtual void RefreshManagerShopSet(ShopSystemManagerViewModel shopSystemManager, string arg)
	{
	}
}
