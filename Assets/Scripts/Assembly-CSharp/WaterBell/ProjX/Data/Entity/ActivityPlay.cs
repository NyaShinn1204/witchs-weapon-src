using System.Collections.Generic;
using Apmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ActivityPlay : PropertyChangeedObservable
	{
		private bool isDelayOpen;

		private bool isOpen;

		private bool actOpen;

		private int serial;

		private bool activityStaminaInit;

		private bool activityStaminaDaily;

		private long lastResetTime;

		private long totalCurrency;

		private bool unlockStory;

		private bool firstEnter;

		private ActivityPlayModeData activityData;

		private ActivityAttribute activityAttribute;

		private TypeCsvActivityGames csvActivityGames;

		private long consumedStamina;

		private long endTimeStamp;

		private long accelerateInstanceSet;

		private List<ApAccLevelInfo> accelerateInstanceList;

		private int battleCount;

		private int battleMax;

		private ActivityStory activityStory;

		private ActivityRankingList activityRankingList;

		public List<ApAccLevelInfo> AccelerateInstanceList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UnlockStory
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long ConsumedStamina
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public ActivityAttribute ActivityAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TypeCsvActivityGames CsvActivityGames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActivityStory ActivityStory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActivityRankingList ActivityRankingList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long AccelerateInstanceSet
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public ActivityPlayModeData ActivityData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long LastResetTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int BattleMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Serial
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BattleCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool ActivityStaminaInit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ActivityStaminaDaily
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long TotalCurrency
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDelayOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ActOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ActivityPlay()
		{
		}

		public ActivityPlay(ActivityGameInstance Act)
		{
		}

		public bool IsFirstTimeEnter()
		{
			return false;
		}

		public bool IsFirstEnter()
		{
			return false;
		}

		private void RefreshCurrentRemainSeconds()
		{
		}

		private long EndTimeToStamp(string timestring)
		{
			return 0L;
		}

		public void setContent(ActivityPlay Act)
		{
		}

		public void Dispose()
		{
		}
	}
}
