using System.Collections.Generic;
using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.Data.Entity
{
	public class ShopInfoHelper
	{
		private static ShopInfoHelper instance;

		private Dictionary<long, int> goodRMBPrice;

		private Dictionary<string, long> leitingPayIDToShopItemID;

		private Dictionary<long, LeitingPayGoodInfo> LeitingGoodToInfo;

		public Dictionary<long, int> GoodRMBPrice
		{
			get
			{
				return null;
			}
		}

		public Dictionary<string, long> LeitingPayIDToShopItemID
		{
			get
			{
				return null;
			}
		}

		public Dictionary<long, LeitingPayGoodInfo> LeitingGoodToInfos
		{
			get
			{
				return null;
			}
		}

		public string LetingPriceType { get; set; }

		public static ShopInfoHelper GetInstance()
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Init()
		{
		}

		public double GetLeitingGoodPriceByID(long goodID)
		{
			return 0.0;
		}

		public static string CanBuyGood(long setId, long shopId, long goodId, int num, long currency_id = 0L)
		{
			return null;
		}

		private static int getCostAfterDiscount(double realPrice, double pricePercent)
		{
			return 0;
		}

		public static string CanRefreshShopSet(long setId)
		{
			return null;
		}

		private static string CheckPriceNeed(int price_type, long currency_id, int cost)
		{
			return null;
		}

		public static ShopGood GetShopGoodByID(long setId, long shopId, long goodId)
		{
			return null;
		}

		public static string GetGoodPriceSpriteNameByPriceType(int type)
		{
			return null;
		}

		public static string GetGoodPriceSpriteNameFromShop(long shopID)
		{
			return null;
		}

		public static bool CanShowShopSet(long setID)
		{
			return false;
		}

		public static bool CanShowShop(long shopID)
		{
			return false;
		}

		public static List<long> GetShopSetListInBigSet(long id)
		{
			return null;
		}

		public static int GetGoodNumInShop(long shopID, long goodID)
		{
			return 0;
		}

		public static string IsVipShopOpen()
		{
			return null;
		}

		public static List<UIRawResData> GetGoodsInfo(long _setID, long _shopID, long _goodsID)
		{
			return null;
		}

		private static long GetID(int _type, long _goodsID, long _goodsValue)
		{
			return 0L;
		}
	}
}
