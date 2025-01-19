public abstract class ActivityPlaySystemManagerControllerBase : Controller
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

	public abstract void InitializeActivityPlaySystemManager(ActivityPlaySystemManagerViewModel activityPlaySystemManager);

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public virtual ActivityPlaySystemManagerViewModel CreateActivityPlaySystemManager()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}

	public virtual void ReceiveInitStamina(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void ReceiveDailyStamina(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void Reset(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	public virtual void GetReward(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishGetRewaed(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishReset(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void UnlockAPStory(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void GetRank(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	public virtual void FinishGetRank(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void Sweep(ActivityPlaySystemManagerViewModel activityPlaySystemManager, SweepArgu arg)
	{
	}

	public virtual void FinishSweep(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void GoToNextFloorRule1(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishGoToNextFloorRule1(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void AttributeAdd(ActivityPlaySystemManagerViewModel activityPlaySystemManager, string arg)
	{
	}

	public virtual void FinishAttributeAdd(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void AttributeReset(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishAttributeReset(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void Rule5Reset(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	public virtual void Rule5GiveUp(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	public virtual void Rule5Getreward(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	public virtual void FinishRule5Reset(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishRule5GiveUp(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishRule5Getreward(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void Rule5UnlockFinalRound(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	public virtual void ChangeKey(ActivityPlaySystemManagerViewModel activityPlaySystemManager, ChangeKeyArg arg)
	{
	}

	public virtual void FinishRule5UnlockFinalRound(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void FinishChangeKey(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void R4ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	public virtual void FinishR4ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public virtual void R5ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	public virtual void FinishR5ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}
}
