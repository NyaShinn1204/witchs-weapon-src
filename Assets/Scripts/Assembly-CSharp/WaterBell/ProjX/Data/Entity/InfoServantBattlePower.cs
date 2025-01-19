using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class InfoServantBattlePower<TValue>
	{
		protected Dictionary<long, TValue> _hashList;

		public int count
		{
			get
			{
				return 0;
			}
		}

		public TValue Item
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public bool ContainsKey(long sKey)
		{
			return false;
		}
	}
}
