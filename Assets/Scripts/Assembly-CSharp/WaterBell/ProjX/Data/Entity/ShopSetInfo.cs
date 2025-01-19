using System.Collections.Generic;
using Google.Protobuf.Collections;
using Shopmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ShopSetInfo : PropertyChangeedObservable
	{
		private long setID;

		private long timeLeft;

		private bool autoRefresh;

		private bool manualRefresh;

		private bool outOfDate;

		private long startTime;

		private long stopTime;

		private bool isOpen;

		private int refreshCount;

		private List<Shop> shops;

		public int VipExtra { get; set; }

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoRefresh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ManualRefresh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long StartTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long StopTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int RefreshCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Shop> Shops
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long SetID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long TimeLeft
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool OutOfDate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanShow()
		{
			return false;
		}

		public void UpdateContent(long id, long timeLeft, bool AutoRefresh, bool ManualRefresh, int refreshCount, long startTime, long stopTime, bool isOpen, RepeatedField<Shopmod.Shop> shopinfos, int vip_Extra)
		{
		}

		private void SetShopSetOutOfDate()
		{
		}

		public Shop GetShopByID(long ID)
		{
			return null;
		}
	}
}
