using Achievemod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableJob : PropertyChangeedObservable
	{
		private long _ID;

		private int status;

		private int valid;

		private int typeID;

		private bool guide;

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

		public bool Guide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Valid
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Type
		{
			get
			{
				return 0;
			}
		}

		public ObservableJob()
		{
		}

		public ObservableJob(long id, int status, int valid, int type, bool guide)
		{
		}

		public void Update(Job content)
		{
		}
	}
}
