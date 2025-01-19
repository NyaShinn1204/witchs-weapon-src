namespace WaterBell.ProjX.Data.Entity
{
	public class GuildMemberInfo
	{
		private long id;

		private string name;

		private int head;

		private int headBox;

		private string icon;

		private string boarder;

		private int privilege;

		private int level;

		private double combatEffectiveness;

		private long time;

		private long enterTime;

		private int dailyVitality;

		private int totalVitality;

		public int ServantCount { get; set; }

		public int WeaponCount { get; set; }

		public int Title { get; set; }

		public long Id
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Privilege
		{
			get
			{
				return 0;
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

		public int Head
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int HeadBox
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double CombatEffectiveness
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public long Time
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long EnterTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int DailyVitality
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalVitality
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GuildMemberInfo(long id, string name, int head, int headBox, int privilege, int level, double combatEffectiveness, long time, long enterTime, int dailyVitality, int totalVitality, int ServantCount, int WeaponCount, int title)
		{
		}
	}
}
