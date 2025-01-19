using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WaterBell.ProjX.Data.Entity
{
	public class ServantCore
	{
		public class SingleServant
		{
			private long servantCardID;

			private int level;

			private long exp;

			private int rank;

			private int star;

			private long[] equipIDArr;

			private int spellActiveLevel;

			private int spellPassiveLevel1;

			private int spellPassiveLevel2;

			private int spellPassiveLevel3;

			private int spellWeaponLevel;

			private int favorabilityLevel;

			private long favorabilityExp;

			private int favorGrade;

			private int weaponLv;

			private long weaponExp;

			private int giftNums;

			private long giftTime;

			private long[] weaponCardIDs;

			private int[] weaponSpellPromoteLvs;

			private int[] wpSkins;

			private int[] wpCurSkin;

			private bool isExist;

			private int currentImage;

			private int imageState;

			private int imagesForFavor;

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

			public int FavorGrade
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int WeaponLv
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

			public int GiftNums
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public long GiftTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public long[] WeaponCardIDs
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int[] WeaponSpellPromoteLvs
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int[] WpSkins
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int[] WpCurSkin
			{
				get
				{
					return null;
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

			public int ImageState
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int ImagesForFavor
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public SingleServant()
			{
			}

			public SingleServant(long cardID, int lv, long exp, long favExp, int rankLv, int starLv, long[] eqArr, int saLv, int sp1Lv, int sp2Lv, int sp3Lv, int favLv, int weaponLv, long weaponExp, long[] weaponCardIDs, int[] weaponSpellProLv, int[] wpSkins, int[] wpCurSkin, bool isExist = true, int fashion = 1, int Image = 1, int imagesForFav = 1)
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

			public void SetEquipIDArr(long e1, long e2, long e3, long e4, long e5, long e6)
			{
			}
		}

		public static int DefaultLevel;

		public static long DefaultExp;

		public static long DefaultFavorexp;

		public static int DefaultFavorLv;

		public static int DefaultFavorGrade;

		public static int DefaultRank;

		public static int DefaultStar;

		public static long DefaultWeaponExp;

		public static int DefaultWeaponLv;

		public static long DefaultEquip;

		public static int DefaultWeaponPromoteLv;

		public static int DefaultWeaponSpellPromoteLv;

		public static int DefaultWeaponSkins;

		public static int DefaultWeaponCurSkin;

		public static int DefaultSpelllActiveLv;

		public static int DefaultPassitivellLv;

		public static int GiftNums;

		public static long GuideServantID;

		public static int GuideLevel;

		public static int GuideRank;

		public static int DefaultCurrentImage;

		public static int DefaultImage;

		public static int DefaultImagesForFavor;

		private Dictionary<long, SingleServant> servantsCardDict;

		public ObservableCollection<ObservableSingleServant> observableServants;

		private List<ServantRuneInfo> servantRuneInfos;

		public ObservableCollection<ObservableSingleServant> ObservableServants
		{
			get
			{
				return null;
			}
		}

		public int Reset(List<SingleServant> clone)
		{
			return 0;
		}

		public SingleServant GetInfoByServantID(long cardID)
		{
			return null;
		}

		public List<ServantRuneInfo> GetAllServantRuneInfos()
		{
			return null;
		}

		public List<ServantRuneSlot> GetServantRuneSlotInfoBySvID(long svID)
		{
			return null;
		}

		public ServantRuneSlot GetServantRuneSlotInfoBySvIDAndIndex(long svID, int index)
		{
			return null;
		}

		public ObservableSingleServant GetObservableServantsByID(long ServantID)
		{
			return null;
		}

		public List<ObservableSingleServant> GetAllUnlockSv()
		{
			return null;
		}

		public ObservableServantWeapon GetObservableServantWeaponByID(long ServantID, long ServantWeaponID)
		{
			return null;
		}

		public void AddObservableServant(SingleServant item)
		{
		}

		public int GetAllServantsCount()
		{
			return 0;
		}

		public void Dispose()
		{
		}
	}
}
