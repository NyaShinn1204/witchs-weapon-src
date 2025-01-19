namespace WaterBell.ProjX.Data.Entity
{
	public class MercenaryServant
	{
		private long servantCardID;

		private int level;

		private int rank;

		private int star;

		private int spellActiveLevel;

		private int spellPassiveLevel1;

		private int weaponLevel;

		private long rID;

		private long addTime;

		private int equips;

		private int favorabilityLevel;

		private int currentImage;

		private ObservableServantWeapon servantWeapons;

		public int FavorabilityLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Equips
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurrentFashion { get; set; }

		public int TimeProfit { get; set; }

		public int EmployCount { get; set; }

		public int EmployDailyCount { get; set; }

		public int EmployProfit { get; set; }

		public int EmployDailyProfit { get; set; }

		public long LastEmployTime { get; set; }

		public string RoleName { get; set; }

		public long ServantCardID
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

		public int Rank
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellActiveLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellPassiveLevel1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int WeaponLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long RID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long AddTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public ObservableServantWeapon ServantWeapons
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MercenaryServant(long servantCardID, string roleName, int level, int rank, int star, int equips, int favorabilityLevel, int spellActiveLevel, int spellPassiveLevel1, int weaponLevel, long rID, long addTime, long wpid, int WeaponSpellPromoteLv, int wpSkins = 1, int wpCurSkin = 1, int TimeProfit = 0, int EmployCount = 0, int EmployProfit = 0, int EmployDailyProfit = 0, long LastEmployTime = 0L, int employDailyCount = 0, int fashion = 1)
		{
		}

		public MiniServant ConvertMini()
		{
			return null;
		}
	}
}
