namespace WaterBell.ProjX.Data.Entity
{
	public class SingleServantSimple
	{
		private long _ID;

		private long servantID;

		private int servantLevelBefore;

		private int servantLevelCurrent;

		private long servantExpBefore;

		private long servantExpCurrent;

		private string servantWideIcon;

		private string servantName;

		private int servantRank;

		private int servantStar;

		private bool isMercenary;

		private long rid;

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public bool IsMercenary
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long Rid
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long ServantID
		{
			get
			{
				return 0L;
			}
		}

		public int ServantLevelBefore
		{
			get
			{
				return 0;
			}
		}

		public int ServantLevelCurrent
		{
			get
			{
				return 0;
			}
		}

		public long ServantExpBefore
		{
			get
			{
				return 0L;
			}
		}

		public long ServantExpCurrent
		{
			get
			{
				return 0L;
			}
		}

		public string ServantWideIcon
		{
			get
			{
				return null;
			}
		}

		public string ServantName
		{
			get
			{
				return null;
			}
		}

		public int ServantRank
		{
			get
			{
				return 0;
			}
		}

		public int ServantStar
		{
			get
			{
				return 0;
			}
		}

		public SingleServantSimple()
		{
		}

		public SingleServantSimple(long uniqueID)
		{
		}

		public SingleServantSimple(MercenaryServant sv)
		{
		}

		public void Update(long exp, int levelLimit)
		{
		}
	}
}
