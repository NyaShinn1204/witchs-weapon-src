using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ExpDevelopInfo
	{
		public List<SvExpItemInfo> itemList;

		public UseItemArgus useItemArgus;

		public long servantCardID;

		public int LevelFake;

		public long ExpFake;

		public int Level;

		public long Exp;

		public long ExpLimitFake;

		public int LevelLimit;

		public ExpDevelopInfo(long servantCardID)
		{
		}

		private ExpDevelopInfo()
		{
		}

		public ExpDevelopInfo Clone()
		{
			return null;
		}

		public string CanAddExp()
		{
			return null;
		}
	}
}
