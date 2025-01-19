namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleLevel : PropertyChangeedObservable
	{
		private long _ID;

		private bool unLocok;

		private int battleCount;

		private int resetCount;

		private bool isClear;

		private bool canSweep;

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public bool UnLocok
		{
			get
			{
				return false;
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

		public int ResetCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsClear
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanSweep
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ObservableSingleLevel()
		{
		}

		public ObservableSingleLevel(long _ID, bool isClear, int stars, int battleCount, int resetCount, bool unLocok, bool canSweep)
		{
		}
	}
}
