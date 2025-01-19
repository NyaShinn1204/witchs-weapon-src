using System.Collections.Generic;
using Resourcemod;

namespace WaterBell.ProjX.Data.Entity
{
	public class RecycleShop
	{
		private List<RecycleItem> recycleItems;

		public List<RecycleItem> RecycleItems
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long TotalPrice { get; set; }

		public void UpdateRecycleShop(RecycleInstance RecycleInstance)
		{
		}

		public RecycleItem GetItem(long id)
		{
			return null;
		}

		public void SellAll()
		{
		}

		public void SellItem(string itemsarg, string itemnumsarg)
		{
		}

		public void Dispose()
		{
		}
	}
}
