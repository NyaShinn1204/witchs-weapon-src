using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class GuildLog
	{
		private int id;

		private long time;

		private int stringID;

		private List<string> argus;

		public int Id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Time
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int StringID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<string> Argus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GuildLog(int id, long time, int stringID, List<string> argus)
		{
		}
	}
}
