using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ActivityAttribute
	{
		private long lastTimeReset;

		private int attributePointNow;

		private int attributePointMax;

		private int attrResetCount;

		private List<int> attributeLevel;

		public int AttrResetCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long LastTimeReset
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int AttributePointNow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int AttributePointMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<int> AttributeLevel
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
