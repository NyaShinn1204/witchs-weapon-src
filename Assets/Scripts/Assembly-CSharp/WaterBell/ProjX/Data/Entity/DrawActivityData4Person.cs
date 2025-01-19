using System.Collections.Generic;
using Activitymod;

namespace WaterBell.ProjX.Data.Entity
{
	public class DrawActivityData4Person : DrawActivityData
	{
		public class DrawData
		{
			public long KeepTime;

			public long ID;

			public DrawData(long sID, long sKeepTime)
			{
			}
		}

		public List<DrawData> _list;

		private Dictionary<long, DrawData> _hash;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public List<long> IDList
		{
			get
			{
				return null;
			}
		}

		public DrawData Item
		{
			get
			{
				return null;
			}
		}

		public DrawActivityData4Person(long drawBaseID, long drawActivityEndTime, ActivityInstanceProto sProto, PersonDraw sPresonDraw)
			: base(0L, 0L, null)
		{
		}

		public void Add(long sID)
		{
		}

		public int IndexOf(long sID)
		{
			return 0;
		}

		public DrawData GetByIndex(int sIndex)
		{
			return null;
		}

		public void Remove(long sID)
		{
		}
	}
}
