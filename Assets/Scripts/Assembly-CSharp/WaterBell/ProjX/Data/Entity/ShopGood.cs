namespace WaterBell.ProjX.Data.Entity
{
	public class ShopGood
	{
		private long shopGoodID;

		private int price;

		private int num;

		private int discount;

		private bool isDiscount;

		public int Discount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsDiscount
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long ShopGoodID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Price
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Num
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ShopGood(long id, int price, int num, int discount, bool isDiscount)
		{
		}
	}
}
