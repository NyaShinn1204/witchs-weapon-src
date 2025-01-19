namespace WaterBell.ProjX.Data.Entity
{
	public class Player
	{
		private ulong ID;

		private ulong roleID;

		private long rmb;

		private int level;

		private long gold;

		private long exp;

		private int vit;

		private int vip;

		private int vittime;

		private long updatevittime;

		private int freeGoldDrawTime;

		private long cdGoldDraw;

		private int freeRMBDrawTime;

		private int buyVitTime;

		private int buyGoldTime;

		private int resetExpedition;

		private long activityStamina;

		public int ResetExpedition
		{
			get
			{
				return 0;
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

		public long RMB
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

		public int Vit
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

		public int Vittime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Updatevittime
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

		public Player()
		{
		}

		public Player(Player clone)
		{
		}

		public Player(object[] arguments)
		{
		}

		public int Reset(object[] arguments)
		{
			return 0;
		}
	}
}
