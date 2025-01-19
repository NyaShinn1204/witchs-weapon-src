namespace WaterBell.ProjX.Data.Entity
{
	public class ServantRuneSlot
	{
		private long SvID;

		private int index;

		private bool haveRune;

		private ObservableSingleRune runeItem;

		public int Index
		{
			get
			{
				return 0;
			}
		}

		public bool HaveRune
		{
			get
			{
				return false;
			}
		}

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public ObservableSingleRune RuneItem
		{
			get
			{
				return null;
			}
		}

		public ServantRuneSlot(long SvID, int index, bool haveRune, ObservableSingleRune runeItem)
		{
		}
	}
}
