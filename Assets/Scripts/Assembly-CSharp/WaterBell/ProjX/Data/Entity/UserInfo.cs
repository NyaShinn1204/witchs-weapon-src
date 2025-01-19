using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Ratemod;
using Timermod;

namespace WaterBell.ProjX.Data.Entity
{
	public class UserInfo : IBindable
	{
		private static UserInfo instance;

		public bool UnLockChallenge;

		public bool UnLockChapter;

		public int test_code;

		private List<ViewModel> vmList;

		private List<IDisposable> Bindings;

		private ServantCore servantInfo;

		private Package packageInfo;

		private OrderInfo orderInfo;

		private Progress progressInfo;

		public InfoServantBattlePower<float> servantPower;

		private ShopAllSets shopAllSets;

		private RecycleShop recycleShop;

		private Achievement achievement;

		private Quest quest;

		private Mail mail;

		private Expedition expedition;

		private ObservablePlayer observablePlayer;

		private Activity activity;

		private ObservablePlayerGuild guild;

		private ActivityPlay activityPlay;

		private Story story;

		private TimeDatas timeDatas;

		private MapField<long, RateInfo> rateInfos;

		private InviteInfo inviteInfo;

		private string battleSaveData;

		private long fashionID;

		private long DEFAUT_FASHION;

		private int lastTimeUserLevel;

		private long lastTimeUserExp;

		public List<ViewModel> VmList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsFirstRestrict { get; set; }

		public MapField<long, RateInfo> RateInfos
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeDatas TimeDatas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string BattleSaveData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long FashionID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long CurrentCombatScoreBeforeBattle { get; set; }

		public int LastTimeUserLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long LastTimeUserExp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public IDisposable AddBinding(IDisposable binding)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public string GetTestCode()
		{
			return null;
		}

		public void Init()
		{
		}

		private void UpdatePlayer(PropertyChangeedObservable target)
		{
		}

		public static UserInfo GetInstance()
		{
			return null;
		}

		public void SetExpedition(List<ExpeditionNode> ExpeditionInfo, List<ExpeditionServant> ExpeditionServantInfo, int Index, int hp)
		{
		}

		public int SetAchievement(List<AchievementJob> finishAchieve, List<AchievementMeta> progressingAchieve)
		{
			return 0;
		}

		public void SetObservablePlayer(ObservablePlayer player)
		{
		}

		public void SetPlayerGuild(ObservablePlayerGuild Guild)
		{
		}

		public void SetServantInfo(List<ServantCore.SingleServant> clone)
		{
		}

		public void SetProgress(List<Progress.SingleProgress> clone, int MaterialLootTimes)
		{
		}

		public void SetMailHaveReaded(string index)
		{
		}

		public void RemoveMailHasAttach(string id)
		{
		}

		public ObservablePlayer GetPlayer()
		{
			return null;
		}

		public InviteInfo GetInviteInfo()
		{
			return null;
		}

		public ObservablePlayerGuild GetGuild()
		{
			return null;
		}

		public void SetActivityPlay(ActivityPlay act)
		{
		}

		public ActivityPlay getActivityPlay()
		{
			return null;
		}

		public Story GetStory()
		{
			return null;
		}

		public void SetActivity(Activity act)
		{
		}

		public Activity getActivity()
		{
			return null;
		}

		public ServantCore GetServantInfo()
		{
			return null;
		}

		public OrderInfo GetOrderInfo()
		{
			return null;
		}

		public Package GetPackage()
		{
			return null;
		}

		public ShopAllSets GetShopAllSets()
		{
			return null;
		}

		public RecycleShop GetRecycleShop()
		{
			return null;
		}

		public Progress GetProgress()
		{
			return null;
		}

		public Mail GetMails()
		{
			return null;
		}

		public Quest GetQuest()
		{
			return null;
		}

		public Achievement GetAchievement()
		{
			return null;
		}

		public Expedition GetExpedition()
		{
			return null;
		}
	}
}
