public abstract class PackageManagerControllerBase : Controller
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
	public PackageItemController PackageItemController { get; set; }

	public abstract void InitializePackageManager(PackageManagerViewModel packageManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual PackageManagerViewModel CreatePackageManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void AddItemByID(PackageManagerViewModel packageManager, long arg)
	{
	}

	public virtual void RemoveItemById(PackageManagerViewModel packageManager, long arg)
	{
	}

	public virtual void ChangeItem(PackageManagerViewModel packageManager, string arg)
	{
	}

	public virtual void SellItem(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	public virtual void UseItem(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	public virtual void UseSpStamina(PackageManagerViewModel packageManager, UseItemArgus arg)
	{
	}

	public virtual void GetRecycleShop(PackageManagerViewModel packageManager)
	{
	}

	public virtual void FinishGetRecycleShop(PackageManagerViewModel packageManager)
	{
	}

	public virtual void SellRecycleItems(PackageManagerViewModel packageManager, string arg)
	{
	}

	public virtual void FinishSellRecycleItems(PackageManagerViewModel packageManager)
	{
	}

	public virtual void SellAllRecycle(PackageManagerViewModel packageManager)
	{
	}

	public virtual void FinishSellAllRecycle(PackageManagerViewModel packageManager)
	{
	}

	public virtual void OpenChest(PackageManagerViewModel packageManager, SellArgument arg)
	{
	}

	public virtual void FinishOpenChest(PackageManagerViewModel packageManager)
	{
	}
}
