namespace WaterBell.ProjX.Data.Entity
{
	public class BordAction
	{
		private long id;

		private string icon;

		private string name;

		private long activity_game;

		private bool unlock;

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

		public bool Unlock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long Activity_Game
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Icon
		{
			get
			{
				return null;
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

		public BordAction(long id, string icon, long name, long activity_game, bool unlock)
		{
		}
	}
}
