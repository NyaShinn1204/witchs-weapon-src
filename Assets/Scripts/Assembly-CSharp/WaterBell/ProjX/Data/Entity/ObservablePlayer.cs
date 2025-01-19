using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Google.Protobuf.Collections;
using Rolemod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservablePlayer : PropertyChangeedObservable
	{
		private long ID;

		public long roleID;

		private string rolename;

		private long diamond;

		private long realRmb;

		private TimedRmb timedRmb;

		private long rmbScore;

		private P<int> level;

		private long gold;

		private int drawCurrency;

		private P<long> exp;

		private int stamina;

		private int vip;

		private long staminaTime;

		private long time0;

		private long everyDayRefreshTime;

		private long staminaTime8;

		private long staminaTime12;

		private long staminaTime18;

		private bool canReceiveVit;

		private int freeGoldDrawTime;

		private long cdGoldDraw;

		private int freeGold10DrawTimes;

		private long cdGold10Draw;

		private int freeRMBDrawTime;

		private int buyStaminaTime;

		private int buyGoldTime;

		private long guildCurrency;

		private List<HeadIcon> head;

		private List<HeadIconBox> headBoxList;

		private List<TimedRmb> timedRmbInfo;

		private List<CharactorInteraction> actionList;

		private List<BordAction> boardActionList;

		private List<UserTitle> titleList;

		private List<int> monthCardDays;

		private List<bool> monthCardSend;

		private int curBoard;

		private int curHead;

		private int curHeadBox;

		private int activityStamina;

		private long activityStaminaTime;

		private int curTitle;

		private int vipExp;

		private int vipPoint;

		private int storyCurrency;

		private int activityStoryCurrency;

		private bool vip2GiftState;

		private int rechargeVipExp;

		private int totalExpireVipExp;

		private List<DayVipExp> dayVipExps;

		private int recycleCurrency;

		private int cscCurrency;

		private int activeCurrencyRed;

		private int activeCurrencyGreen;

		private int activeCurrencyYellow;

		private int activeCurrencyBlue;

		private int preRoleLevel;

		private int Challenge;

		private bool[] challengeState;

		private ObservableCollection<ObservableSingleFashion> fashions;

		private bool canFreeDraw;

		private PropertyChangeedObservable canFreeDrawChange;

		private int playerVitLimitCurrent;

		private Dictionary<int, int> GameCamp;

		private bool vip5GiftState;

		private bool isReceivePhoneReward;

		private static int[] ChallengeBit;

		public Dictionary<int, int> UserGameCamp
		{
			get
			{
				return null;
			}
		}

		public int TimeZone { get; set; }

		public int FakeDrawMailTimes { get; set; }

		public bool TwCBTReward { get; set; }

		public int RechargeVipExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalExpireVipExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Vip2GiftState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Vip5GiftState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsReceivePhoneReward
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<DayVipExp> DayVipExps
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ActivityStamina
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long ActivityStaminaTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int CurTitle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int StoryCurrency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActivityStoryCurrency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int VipExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int VipPoint
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurHead
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurHeadBox
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<HeadIcon> HeadList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<HeadIconBox> HeadBoxList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<TimedRmb> TimedRmbInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int CurBoard
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<BordAction> BoardActionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CharactorInteraction> ActionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<UserTitle> TitleList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> MonthCardDays
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<bool> MonthCardSend
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CanFreeDraw
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ObservableCollection<ObservableSingleFashion> Fashions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long RoleID
		{
			get
			{
				return 0L;
			}
		}

		public long Diamond
		{
			get
			{
				return 0L;
			}
			private set
			{
			}
		}

		public long RealRmb
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long TotalDiamond
		{
			get
			{
				return 0L;
			}
		}

		public long RmbScore
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DrawCurrency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Gold
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long GuildCurrency
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int PreRoleLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Exp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Stamina
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Vip
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Vittime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long EveryDayRefreshTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long Time0
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int FreeGoldDrawTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CanReceiveVit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long CDGoldDraw
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int FreeGold10DrawTimes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long CdGold10Draw
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int FreeRMBDrawTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BuyVitTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BuyGoldTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public P<int> ObservarLevel
		{
			get
			{
				return null;
			}
		}

		public P<long> ObservarExp
		{
			get
			{
				return null;
			}
		}

		public int CscCurrency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RecycleCurrency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActiveCurrencyRed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActiveCurrencyYellow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActiveCurrencyBlue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActiveCurrencyGreen
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long StaminaTime8
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long StaminaTime12
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long StaminaTime18
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Rolename
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool[] ChallengeState
		{
			get
			{
				return null;
			}
		}

		public ObservablePlayer()
		{
		}

		public ObservablePlayer(long uid, RoleInstanceProto role, RoleTimeInstance time, int previousRoleLv, RepeatedField<FashionInstance> Fashions)
		{
		}

		public void SubscribeCanFreeDrawChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void UpdateTime(RoleTimeInstance time)
		{
		}

		public void setContent(ObservablePlayer player)
		{
		}

		public void AddFashion(long id)
		{
		}

		public ObservableSingleFashion GetFashionByID(long id)
		{
			return null;
		}

		public void AddRealDiamond(long num)
		{
		}

		public void AddDiamondNotFromPay(long num)
		{
		}

		public void ConsumeDiamond(long cost)
		{
		}

		private bool GetChallengeBit(int index)
		{
			return false;
		}

		public int GetCurrentLevel()
		{
			return 0;
		}

		public bool GetHeadStateById(long id)
		{
			return false;
		}

		public CharactorInteraction GetActionById(long id)
		{
			return null;
		}

		public int GetMonthCardDayById(int id)
		{
			return 0;
		}

		public bool GetMonthCardSendById(int id)
		{
			return false;
		}

		public void SetMonthCardDayById(int id, int value)
		{
		}

		public void SetMonthCardSendById(int id, bool value)
		{
		}

		public BordAction GetBordActionById(long id)
		{
			return null;
		}

		public UserTitle GetTitleById(long id)
		{
			return null;
		}

		public bool GetHeadBoxStateById(long id)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
