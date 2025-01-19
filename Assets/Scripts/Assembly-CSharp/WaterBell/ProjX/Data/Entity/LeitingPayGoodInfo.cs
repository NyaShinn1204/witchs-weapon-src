namespace WaterBell.ProjX.Data.Entity
{
	public class LeitingPayGoodInfo
	{
		public long ShopGoodID;

		public double Price;

		public string PriceType;

		public string SDKPrice;

		public LeitingPayGoodInfo(long ShopGoodID, double Price, string PriceType, string SDKPrice)
		{
		}

		public double Price4SDK()
		{
			return 0.0;
		}

		public double Price4UI()
		{
			return 0.0;
		}
	}
}
