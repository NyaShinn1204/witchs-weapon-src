namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleItem : PropertyChangeedObservable
	{
		private long _ID;

		private int _num;

		private int _max;

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public int Num
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Max
		{
			get
			{
				return 0;
			}
		}

		public ObservableSingleItem()
		{
		}

		public ObservableSingleItem(long id, int num, int max)
		{
		}
	}
}
