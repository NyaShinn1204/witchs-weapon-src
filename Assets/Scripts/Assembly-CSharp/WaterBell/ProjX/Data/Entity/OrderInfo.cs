using System.Collections.Generic;
using System.Runtime.InteropServices;
using Shopmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class OrderInfo
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DealOrderResultDelegate(string orderid, long goodID);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void GiveUpResultDelegate(string orderid, long goodID);

		public DealOrderResultDelegate DealOrderResult;

		public GiveUpResultDelegate GiveUpResult;

		private List<OrderSingleInfo> orders;

		public OrderSingleInfo GetOrderSingleInfo(string id)
		{
			return null;
		}

		public void UpdateOrderInfo(OrderResult orderinfo)
		{
		}

		public void AddOrderInfo(string orderID, long goodID, bool isShiped)
		{
		}

		public void DealOrderInfo(string OrderNum, string goodid = null)
		{
		}

		public void CheckUnShipOrder()
		{
		}

		public void Dispose()
		{
		}
	}
}
