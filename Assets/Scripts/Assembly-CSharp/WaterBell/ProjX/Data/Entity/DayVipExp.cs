using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class DayVipExp
	{
		private int exp;

		private List<VipExp> expBySource;

		public int TodayExpireVipExp { get; set; }

		public int Exp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<VipExp> ExpBySource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
