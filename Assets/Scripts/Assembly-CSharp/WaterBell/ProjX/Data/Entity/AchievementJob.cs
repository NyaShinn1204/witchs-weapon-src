namespace WaterBell.ProjX.Data.Entity
{
	public class AchievementJob
	{
		public const int ALREADY_RECEIVE = 1;

		private long _ID;

		private int status;

		public long ID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Status
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isAlreadyReceive()
		{
			return false;
		}
	}
}
