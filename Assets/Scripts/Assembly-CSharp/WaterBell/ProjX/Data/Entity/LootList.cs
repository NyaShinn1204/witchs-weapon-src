using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class LootList
	{
		private long lootStaminaInc;

		private long lootActivityStaminaInc;

		private int lootGuildInc;

		private int lootGuildvitalityInc;

		private long roleExpInc;

		private long svExpInc;

		private long goldInc;

		private long rmbInc;

		private long realRmbInc;

		private int drawCurrencyInc;

		private long storyInc;

		private long activityStoryInc;

		private int cscInc;

		private int redInc;

		private int yellowInc;

		private int greenInc;

		private int blueInc;

		private int vipExp;

		private int vipPoint;

		private List<long> lootSvCardList;

		private List<long> lootFashionList;

		private List<long> lootMonthCardList;

		private List<long> lootHeadList;

		private List<long> lootHeadFrameList;

		private List<long> lootTitleList;

		private List<long> lootCharactorGestureList;

		private List<long> lootSvDisplayGestureList;

		private List<LootServantIMage> lootServantImageList;

		private List<LootSvWeaponFashion> lootSvWeaponFashionList;

		private List<LootServantFav> favInc;

		private Dictionary<long, int> lootItemDict;

		private Dictionary<long, int> lootSvEquipDict;

		private List<long> lootSvWeaponDict;

		public long PlayerExpInc
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long ServantExpInc
		{
			get
			{
				return 0L;
			}
		}

		public long LootStaminaInc
		{
			get
			{
				return 0L;
			}
		}

		public int LootGuildInc
		{
			get
			{
				return 0;
			}
		}

		public long GoldInc
		{
			get
			{
				return 0L;
			}
		}

		public int CscInc
		{
			get
			{
				return 0;
			}
		}

		public long RealRmbInc
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long RmbInc
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int RedInc
		{
			get
			{
				return 0;
			}
		}

		public int VipExp
		{
			get
			{
				return 0;
			}
		}

		public int VipPoint
		{
			get
			{
				return 0;
			}
		}

		public int YellowInc
		{
			get
			{
				return 0;
			}
		}

		public int GreenInc
		{
			get
			{
				return 0;
			}
		}

		public int BlueInc
		{
			get
			{
				return 0;
			}
		}

		public long LootActivityStaminaInc
		{
			get
			{
				return 0L;
			}
		}

		public int LootGuildvitalityInc
		{
			get
			{
				return 0;
			}
		}

		public int DrawCurrencyInc
		{
			get
			{
				return 0;
			}
		}

		public List<LootServantFav> FavInc
		{
			get
			{
				return null;
			}
		}

		public long StoryInc
		{
			get
			{
				return 0L;
			}
		}

		public long ActivityStoryInc
		{
			get
			{
				return 0L;
			}
		}

		public List<long> LootMonthCardList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootTitleList
		{
			get
			{
				return null;
			}
		}

		public Dictionary<long, int> LootItemsDict
		{
			get
			{
				return null;
			}
		}

		public Dictionary<long, int> LootSvEquipDict
		{
			get
			{
				return null;
			}
		}

		public List<long> LootSvCardIDList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootHeadFrameList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootHeadList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootFashionList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootCharactorGestureList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootSvDisplayGestureList
		{
			get
			{
				return null;
			}
		}

		public List<long> LootSvWeaponDict
		{
			get
			{
				return null;
			}
		}

		public List<LootSvWeaponFashion> LootSvWeaponFashionList
		{
			get
			{
				return null;
			}
		}

		public List<LootServantIMage> LootServantImageList
		{
			get
			{
				return null;
			}
		}

		public void Parse(RepeatedField<LootObject> lootList)
		{
		}

		public void Reset()
		{
		}
	}
}
