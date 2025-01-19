namespace WaterBell.ProjX.Data.Entity
{
	public class CharactorInteraction
	{
		private long id;

		private string icon;

		private string name;

		private string description;

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

		public string Description
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

		public CharactorInteraction(long id, string icon, long name, long description, bool unlock)
		{
		}
	}
}
