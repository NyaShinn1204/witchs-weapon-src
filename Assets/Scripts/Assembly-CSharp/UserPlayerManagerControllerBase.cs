public abstract class UserPlayerManagerControllerBase : Controller
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

	public abstract void InitializeUserPlayerManager(UserPlayerManagerViewModel userPlayerManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual UserPlayerManagerViewModel CreateUserPlayerManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void ReceiveStamina(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void FinishReceiveStamina(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ChangeCurrentHead(UserPlayerManagerViewModel userPlayerManager, int arg)
	{
	}

	public virtual void ChangeCurrentHeadBox(UserPlayerManagerViewModel userPlayerManager, int arg)
	{
	}

	public virtual void ChangeHeadAndBox(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public virtual void ReceiveVip2Gift(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ReceiveVip5Gift(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void FinishReceiveGift(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ChangeCurrentSvAction(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public virtual void ReName(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public virtual void FinishReName(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ChangeTitle(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public virtual void Redeem(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public virtual void FinishRedeem(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ReceivePhoneReward(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ReceiveInviteReward(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public virtual void FinishReceiveInviteReward(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void ReceiveBeInvitedReward(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public virtual void FinishReceiveBeInvitedReward(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void UseInviteCode(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public virtual void FinishUseInviteCode(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void SyncInviteInfo(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public virtual void FinishSyncInviteInfo(UserPlayerManagerViewModel userPlayerManager)
	{
	}
}
