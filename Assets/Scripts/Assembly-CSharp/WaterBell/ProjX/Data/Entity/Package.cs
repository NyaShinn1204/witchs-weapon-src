using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WaterBell.ProjX.Data.Entity
{
	public class Package
	{
		public class SinglePackage
		{
			private long _ID;

			private int count;

			private int _max;

			public long ID
			{
				get
				{
					return 0L;
				}
			}

			public int Count
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public SinglePackage()
			{
			}

			public SinglePackage(SinglePackage clone)
			{
			}

			public SinglePackage(object[] arguments)
			{
			}

			public SinglePackage(long originID, int originCount, int max)
			{
			}

			public int Reset(object[] arguments)
			{
				return 0;
			}
		}

		public ObservableCollection<ObservableSingleItem> observableItems;

		public ObservableCollection<ObservableSingleItem> observableEquips;

		private Dictionary<long, ObservableSingleItem> observableItemsDic;

		private Dictionary<long, ObservableSingleItem> observableEquipsDic;

		public ObservableCollection<ObservableSingleRune> observableRunes;

		private Dictionary<long, ObservableSingleRune> idToRuneDic;

		public ObservableCollection<ObservableSingleItem> ObservableItems
		{
			get
			{
				return null;
			}
		}

		public ObservableCollection<ObservableSingleItem> ObservableEquips
		{
			get
			{
				return null;
			}
		}

		public ObservableCollection<ObservableSingleRune> ObservableRunes
		{
			get
			{
				return null;
			}
		}

		public int GetAllCount()
		{
			return 0;
		}

		public int GetItemNum(long ID)
		{
			return 0;
		}

		public int GetItemOrEquipNum(long ID)
		{
			return 0;
		}

		public ObservableSingleItem GetObservableSingleItemByID(long ID)
		{
			return null;
		}

		public ObservableSingleItem GetObservableSingleEquipByID(long ID)
		{
			return null;
		}

		public ObservableSingleRune GetObservableSingleRuneByID(long ID)
		{
			return null;
		}

		public void UpdateItem(long ID, int num, int max)
		{
		}

		public void UpdateEquip(long ID, int num, int max)
		{
		}

		public void UseRune(int ID, int num = 1)
		{
		}

		public void ChangeItemCount(long ID, int num)
		{
		}

		public List<ObservableSingleItem> GetItemsBySubType(int subType)
		{
			return null;
		}

		public void ChangeEquipCount(long ID, int num)
		{
		}

		private void AddItem(long ID, int num)
		{
		}

		private void AddEquip(long ID, int num)
		{
		}

		public void Dispose()
		{
		}

		public void SellAllItemByType(int type = 4)
		{
		}
	}
}
