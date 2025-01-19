using Activitymod;

namespace WaterBell.ProjX.Data.Entity
{
	public class DrawActivityData
	{
		private long drawBaseID;

		private long drawActivityEndTime;

		private TypeCsvActivity csvActivityData;

		public ActivityInstanceProto proto;

		public long DrawBaseID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long DrawActivityEndTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string FormatEndTime
		{
			get
			{
				return null;
			}
		}

		public TypeCsvActivity CsvActivityData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DrawActivityData(long drawBaseID, long drawActivityEndTime, ActivityInstanceProto sProto)
		{
		}

		public DrawActivityData(long drawBaseID)
		{
		}

		public bool isDrawActivityOpen()
		{
			return false;
		}
	}
}
