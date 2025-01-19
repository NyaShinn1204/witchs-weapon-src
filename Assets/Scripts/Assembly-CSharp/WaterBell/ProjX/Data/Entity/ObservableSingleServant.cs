using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleServant : PropertyChangeedObservable
	{
		private long servantCardID;

		private P<int> level;

		private long exp;

		private int rank;

		private int star;

		private long[] equipIDArr;

		private int spellActiveLevel;

		private int spellPassiveLevel1;

		private int spellPassiveLevel2;

		private int spellPassiveLevel3;

		private P<int> favorabilityLevel;

		private long favorabilityExp;

		private int spellWeaponLevel;

		private int favorGrade;

		private int weaponLevel;

		private long weaponExp;

		private int giftNums;

		private long giftTime;

		private bool isExist;

		private Dictionary<int, ServantImage> servantImageList;

		private Dictionary<int, bool> servantImageFavState;

		private int currentImage;

		private ObservableCollection<ObservableServantWeapon> servantWeapons;

		private TypeCsvServant svTableData;

		private TypeCsvServantClient svClientTableData;

		private TypeCsvServantRankInfo svRankTableData;

		private List<long> commonSlots;

		private List<long> specialSlots;

		public long ServantCardID
		{
			get
			{
				return 0L;
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Exp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int WeaponLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurrentImage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long WeaponExp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Rank
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellActiveLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellPassiveLevel1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellPassiveLevel2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpellPassiveLevel3
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int FavorabilityLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long FavorabilityExp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool IsExist
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Dictionary<int, ServantImage> ServantImageList
		{
			get
			{
				return null;
			}
		}

		public Dictionary<int, bool> ServantImageFavState
		{
			get
			{
				return null;
			}
		}

		public ObservableCollection<ObservableServantWeapon> ServantWeapons
		{
			get
			{
				return null;
			}
		}

		public ObservableSingleServant()
		{
		}

		public ObservableSingleServant(ServantCore.SingleServant servant)
		{
		}

		public MiniServant ConvertMini()
		{
			return null;
		}

		private void UpdatePlayer(PropertyChangeedObservable target)
		{
		}

		public void UpdateContent(ServantCore.SingleServant servant)
		{
		}

		private void BuildCurrentSingleServantImageList(ServantCore.SingleServant servant)
		{
		}

		private void UpdateWeapon(PropertyChangeedObservable target)
		{
		}

		private void UpdateWhenAddLv(int value)
		{
		}

		public long GetEquip(int idx)
		{
			return 0L;
		}

		public void SetEquip(int idx, long val)
		{
		}

		public bool[] GetEquipStateArr()
		{
			return null;
		}

		public long[] GetEquipIDArr()
		{
			return null;
		}

		public void SetEquipIDArrByIndex(int index, long id)
		{
		}

		public void SetServantImageNotNew(int serial)
		{
		}

		public bool CheckServantImage(int serial)
		{
			return false;
		}

		public void UnlockServantImage(int serial)
		{
		}

		public bool getServantImageFavStateBySerial(int serial)
		{
			return false;
		}

		public void UnlockServantImageFavState(int serial)
		{
		}

		public TypeCsvServant GetSvTD()
		{
			return null;
		}

		public TypeCsvServantClient GetSvCTD()
		{
			return null;
		}

		public TypeCsvServantRankInfo GetRankTD()
		{
			return null;
		}

		public TypeCsvServantEquip GetEquipTD(int eqSlotNum)
		{
			return null;
		}

		public TypeCsvServantEquipClient GetEquipCTD(int eqSlotNum)
		{
			return null;
		}

		public TypeCsvServantStarInfo GetStarTD()
		{
			return null;
		}

		public TypeCsvServantFavorability GetFavTD()
		{
			return null;
		}
	}
}
