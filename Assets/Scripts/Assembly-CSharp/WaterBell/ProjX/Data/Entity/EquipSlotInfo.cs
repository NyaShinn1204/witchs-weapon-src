using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class EquipSlotInfo : PropertyChangeedObservable
	{
		private long ID;

		private List<long> ComposeNeedEquipList;

		private List<long> ComposeNeedItemList;

		private bool isCanCompose;

		private bool isEquip;

		private bool isHave;

		public long EquipID
		{
			get
			{
				return 0L;
			}
		}

		public bool IsEquip
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsHave
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsCanCompose
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public EquipSlotInfo(long ID, bool isEquip)
		{
		}

		public void UpdateEquipIndexInfo(long ID, bool isEquip)
		{
		}

		public bool IsComposeNeedEquip(long id)
		{
			return false;
		}

		public bool IsComposeNeedItem(long id)
		{
			return false;
		}

		private void GetComposeInfo(long ID)
		{
		}
	}
}
