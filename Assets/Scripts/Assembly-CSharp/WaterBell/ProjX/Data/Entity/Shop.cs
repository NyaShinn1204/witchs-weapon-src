using System.Collections.Generic;
using Google.Protobuf.Collections;
using Shopmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class Shop
	{
		private long shopID;

		private int remainShopItemNum;

		private int maxShopItemNum;

		private List<ShopGood> goods;

		public long ShopID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int RemainShopItemNum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxShopItemNum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<ShopGood> Goods
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shop(long ID, RepeatedField<Goods> goodInfos, int shopNum)
		{
		}

		public ShopGood GetGoodByID(long id)
		{
			return null;
		}
	}
}
