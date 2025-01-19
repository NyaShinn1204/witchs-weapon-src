using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ServantRuneInfo
	{
		private long SvID;

		private List<long> runeSlots;

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public List<long> RuneSlots
		{
			get
			{
				return null;
			}
		}

		public ServantRuneInfo(long SvID, List<long> runeSlots)
		{
		}
	}
}
