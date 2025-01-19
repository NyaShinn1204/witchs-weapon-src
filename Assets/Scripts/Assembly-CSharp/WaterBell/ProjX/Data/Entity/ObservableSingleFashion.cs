namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleFashion : PropertyChangeedObservable
	{
		private long id;

		private bool isOwn;

		private int composePieceNum;

		private int priceInGameData;

		public long Id
		{
			get
			{
				return 0L;
			}
		}

		public bool IsOwn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int ComposePieceNum
		{
			get
			{
				return 0;
			}
		}

		public bool isDiscount()
		{
			return false;
		}

		public void UpdateObservableSingleFashion(long id, bool own, int composePieceNum)
		{
		}
	}
}
