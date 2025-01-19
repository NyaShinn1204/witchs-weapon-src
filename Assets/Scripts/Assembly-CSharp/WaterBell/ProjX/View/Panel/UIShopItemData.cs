namespace WaterBell.ProjX.View.Panel
{
	public class UIShopItemData : UIRawResData
	{
		public static readonly string ShopAtlasPath;

		public static readonly string ShopsoldOutAtlasPath;

		public static readonly string ShopItemBgAtlasPath;

		public static readonly string ShopExtraImgAtlasPath;

		private TypeCsvGoods rawGoodData;

		private GoodInfo _goodInfo;

		public long shopBigSetID;

		public long shopSetID;

		public long shopID;

		public int vipExtra;

		private int sort;

		public string goodName;

		public string extraImgSpriteName;

		public string ohterNumber;

		public string extraDesc;

		public string soldOutSpriteName;

		public string discountSpriteName;

		public string bgSpriteName;

		public string price1IconSpriteName;

		public int price1Val;

		public string price2IconSpriteName;

		public int price2Val;

		public long goodID
		{
			get
			{
				return 0L;
			}
		}

		public int goodCount
		{
			get
			{
				return 0;
			}
		}

		public GoodInfo goodInfo
		{
			get
			{
				return null;
			}
		}

		public int goodSort
		{
			get
			{
				return 0;
			}
		}

		public override UIAtlas rawSelectedIconAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas extraImgAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas soldOutAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas bgAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas price1IconAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas price2IconAtlas
		{
			get
			{
				return null;
			}
		}

		public UIShopItemData(GoodInfo gInfo, long shopID, long shopSetID, long shopBigSetID, int vipExtra = 0)
		{
		}

		protected override void InitOtherAttrs()
		{
		}

		private void InitGoodSpecialAttrs()
		{
		}

		private void InitGoodsInfo()
		{
		}

		private void InitBgSprite()
		{
		}

		private string GetOherNumber()
		{
			return null;
		}

		private string GetExtraImgSpriteName()
		{
			return null;
		}

		private string GetBgSpriteName()
		{
			return null;
		}

		private string GetRawSelectedIconSpriteName()
		{
			return null;
		}

		private void HandlePriceInfo()
		{
		}
	}
}
