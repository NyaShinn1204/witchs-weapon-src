namespace WaterBell.ProjX.Data.Entity
{
	public class OrderSingleInfo
	{
		private string orderID;

		private bool isShiped;

		private long goodID;

		public string OrderID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsShiped
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long GoodID
		{
			get
			{
				return 0L;
			}
		}

		public OrderSingleInfo(string orderID, long goodID, bool isShiped)
		{
		}

		public void Update(bool isShip)
		{
		}
	}
}
