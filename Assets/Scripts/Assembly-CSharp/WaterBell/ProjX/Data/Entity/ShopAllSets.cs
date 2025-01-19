using System.Collections.Generic;
using Google.Protobuf.Collections;
using Shopmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ShopAllSets
	{
		private List<ShopSetInfo> ShopSetInfos;

		private List<long> GoodsRMBBought;

		private P<bool> secretShop1State;

		private P<bool> secretShop2State;

		private P<bool> freshSecretShopSetstate;

		private List<long> freshSecretShopSets;

		private List<long> Special1IDs;

		private List<long> Special2IDs;

		public long GoodsRMBTimes { get; set; }

		public List<ShopSetInfo> AllShopSetInfos
		{
			get
			{
				return null;
			}
		}

		public List<long> AllGoodsRMBBought
		{
			get
			{
				return null;
			}
		}

		public P<bool> ObservarSecretShop1State
		{
			get
			{
				return null;
			}
		}

		public P<bool> ObservarSecretShop2State
		{
			get
			{
				return null;
			}
		}

		public P<bool> ObservableFreshSecretShopSetState
		{
			get
			{
				return null;
			}
		}

		public List<long> FreshSecretShopSets
		{
			get
			{
				return null;
			}
		}

		public void UpdateShopSets(long id, long timeLeft, bool AutoRefresh, bool ManualRefresh, int refreshCount, long startTime, long endTime, bool isOpen, RepeatedField<Shopmod.Shop> shops, int VipExtra)
		{
		}

		public void RefreshAllSetRefreshCount()
		{
		}

		private void RefreshCurrentRemainSeconds()
		{
		}

		public ShopSetInfo GetShopSetByID(long ID)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
