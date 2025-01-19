using Achievemod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableMetaInfo : PropertyChangeedObservable
	{
		private long jobID;

		private int dailyOrTotal;

		private int typeID;

		private int meta;

		public long JobID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int DailyOrTotal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TypeID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Meta
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ObservableMetaInfo()
		{
		}

		public ObservableMetaInfo(long jobID, int dailyOrTotal, int typeID, int meta)
		{
		}

		public void Update(MetaInfo content)
		{
		}
	}
}
