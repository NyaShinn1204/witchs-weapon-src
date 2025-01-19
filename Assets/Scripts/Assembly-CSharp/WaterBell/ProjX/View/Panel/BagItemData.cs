namespace WaterBell.ProjX.View.Panel
{
	public class BagItemData
	{
		public long itemID;

		public int stackNum;

		private string itemLabel;

		public float itemFavExp;

		public int moneyValue;

		public int consumedNum;

		public int consumedMoney;

		public float increasedTotalExp;

		public BagItemData()
		{
		}

		public BagItemData(long id, int num, int money, float favExp)
		{
		}

		public void reset()
		{
		}

		public string getItemLabel()
		{
			return null;
		}

		public void ConsumeOne()
		{
		}

		public void ReturnOne()
		{
		}

		public void ExecConsume()
		{
		}
	}
}
