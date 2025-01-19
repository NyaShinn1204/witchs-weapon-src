public class MainSceneManagerBase : SceneManager
{
	private MainSceneGlobalManagerViewModel _MainSceneGlobalManager;

	private StorySystemManagerViewModel _StorySystemManager;

	private ActivityPlaySystemManagerViewModel _ActivityPlaySystemManager;

	private FashionSystemManagerViewModel _FashionSystemManager;

	private GuildMercenaryManagerViewModel _GuildMercenaryManager;

	private GuildManagerViewModel _GuildManager;

	private GuildUserManagerViewModel _GuildUserManager;

	private PhoneReminderSystemManagerViewModel _PhoneReminderSystemManager;

	private ShopSystemManagerViewModel _ShopSystemManager;

	private QuestSystemManagerViewModel _QuestSystemManager;

	private AchievementSystemManagerViewModel _AchievementSystemManager;

	private CurrentLevelDetailViewModel _CurrentLevelDetail;

	private ProgressSystemManagerViewModel _ProgressSystemManager;

	private RuneManagerViewModel _RuneManager;

	private PackageManagerViewModel _PackageManager;

	private CurrentServantStarInfoViewModel _CurrentServantStarInfo;

	private CurrentServantWeaponInfoViewModel _CurrentServantWeaponInfo;

	private SingleServantViewModel _SingleServant;

	private ServantListManagerViewModel _ServantCore;

	private ExpeditionManagerViewModel _ExpeditionManager;

	private MailManagerViewModel _MailManager;

	private PurchaseSystemManagerViewModel _PurchaseSystemManager;

	private DrawSystemManagerViewModel _DrawSystemManager;

	private UserAchievementManagerViewModel _UserAchievementManager;

	private UserPlayerManagerViewModel _UserPlayerManager;

	private MainSceneGlobalManagerController _MainSceneGlobalManagerController;

	private UserPlayerManagerController _UserPlayerManagerController;

	private UserAchievementManagerController _UserAchievementManagerController;

	private DrawSystemManagerController _DrawSystemManagerController;

	private PurchaseSystemManagerController _PurchaseSystemManagerController;

	private MailManagerController _MailManagerController;

	private MailContentInfoController _MailContentInfoController;

	private ExpeditionManagerController _ExpeditionManagerController;

	private ServantListManagerController _ServantListManagerController;

	private SingleServantController _SingleServantController;

	private SingleServantFavController _SingleServantFavController;

	private ServantListItemController _ServantListItemController;

	private CurrentServantWeaponInfoController _CurrentServantWeaponInfoController;

	private ServantWeaponExpItemController _ServantWeaponExpItemController;

	private CurrentServantStarInfoController _CurrentServantStarInfoController;

	private PackageManagerController _PackageManagerController;

	private PackageItemController _PackageItemController;

	private RuneManagerController _RuneManagerController;

	private RuneItemController _RuneItemController;

	private ProgressSystemManagerController _ProgressSystemManagerController;

	private ProgressChapterController _ProgressChapterController;

	private ProgressLevelController _ProgressLevelController;

	private CurrentLevelDetailController _CurrentLevelDetailController;

	private DailyInstanceSetController _DailyInstanceSetController;

	private DailyInstanceController _DailyInstanceController;

	private AchievementSystemManagerController _AchievementSystemManagerController;

	private AchievementInProgressController _AchievementInProgressController;

	private AchievementCompleteController _AchievementCompleteController;

	private QuestSystemManagerController _QuestSystemManagerController;

	private QuestInfoController _QuestInfoController;

	private ShopSystemManagerController _ShopSystemManagerController;

	private PhoneReminderSystemManagerController _PhoneReminderSystemManagerController;

	private GuildUserManagerController _GuildUserManagerController;

	private GuildManagerController _GuildManagerController;

	private GuildMercenaryManagerController _GuildMercenaryManagerController;

	private FashionSystemManagerController _FashionSystemManagerController;

	private ActivityPlaySystemManagerController _ActivityPlaySystemManagerController;

	private StorySystemManagerController _StorySystemManagerController;

	public MainSceneManagerSettings _MainSceneManagerSettings;

	[Inject]
	public virtual MainSceneGlobalManagerViewModel MainSceneGlobalManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual StorySystemManagerViewModel StorySystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ActivityPlaySystemManagerViewModel ActivityPlaySystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual FashionSystemManagerViewModel FashionSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildMercenaryManagerViewModel GuildMercenaryManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildManagerViewModel GuildManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildUserManagerViewModel GuildUserManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PhoneReminderSystemManagerViewModel PhoneReminderSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ShopSystemManagerViewModel ShopSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual QuestSystemManagerViewModel QuestSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual AchievementSystemManagerViewModel AchievementSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentLevelDetailViewModel CurrentLevelDetail
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ProgressSystemManagerViewModel ProgressSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual RuneManagerViewModel RuneManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PackageManagerViewModel PackageManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentServantStarInfoViewModel CurrentServantStarInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentServantWeaponInfoViewModel CurrentServantWeaponInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual SingleServantViewModel SingleServant
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ServantListManagerViewModel ServantCore
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ExpeditionManagerViewModel ExpeditionManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual MailManagerViewModel MailManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PurchaseSystemManagerViewModel PurchaseSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual DrawSystemManagerViewModel DrawSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual UserAchievementManagerViewModel UserAchievementManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual UserPlayerManagerViewModel UserPlayerManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual MainSceneGlobalManagerController MainSceneGlobalManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual UserPlayerManagerController UserPlayerManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual UserAchievementManagerController UserAchievementManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual DrawSystemManagerController DrawSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PurchaseSystemManagerController PurchaseSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual MailManagerController MailManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual MailContentInfoController MailContentInfoController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ExpeditionManagerController ExpeditionManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ServantListManagerController ServantListManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual SingleServantController SingleServantController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual SingleServantFavController SingleServantFavController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ServantListItemController ServantListItemController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentServantWeaponInfoController CurrentServantWeaponInfoController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ServantWeaponExpItemController ServantWeaponExpItemController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentServantStarInfoController CurrentServantStarInfoController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PackageManagerController PackageManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PackageItemController PackageItemController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual RuneManagerController RuneManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual RuneItemController RuneItemController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ProgressSystemManagerController ProgressSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ProgressChapterController ProgressChapterController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ProgressLevelController ProgressLevelController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual CurrentLevelDetailController CurrentLevelDetailController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual DailyInstanceSetController DailyInstanceSetController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual DailyInstanceController DailyInstanceController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual AchievementSystemManagerController AchievementSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual AchievementInProgressController AchievementInProgressController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual AchievementCompleteController AchievementCompleteController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual QuestSystemManagerController QuestSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual QuestInfoController QuestInfoController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ShopSystemManagerController ShopSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual PhoneReminderSystemManagerController PhoneReminderSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildUserManagerController GuildUserManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildManagerController GuildManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual GuildMercenaryManagerController GuildMercenaryManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual FashionSystemManagerController FashionSystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual ActivityPlaySystemManagerController ActivityPlaySystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Inject]
	public virtual StorySystemManagerController StorySystemManagerController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Setup()
	{
	}

	public override void Initialize()
	{
	}
}
