using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class GameDataHelper
	{
		private static GameDataHelper _instance;

		private double[] _attributeValue;

		private Dictionary<long, List<TypeCsvServantWeapon>> ServantIdToWeapon;

		private Dictionary<long, long> ServantItemToServant;

		private Dictionary<long, TypeCsvKrGoods> GoodToKrInfo;

		private Dictionary<long, TypeCsvTwGoods> GoodToTwInfo;

		private List<long> ComposeServantWeaponNeedItem;

		private Dictionary<long, List<long>> Ap5RoundTypeToBuffs;

		private List<long> PromoteServantWeaponNeedItem;

		private Dictionary<long, long> instanceSetToFrontInstance;

		private Dictionary<long, List<TypeCsvServantImage>> SvIDToImageList;

		private int CORE_INSTANCE_NUM;

		private int CORE_INSTANCE_CUMULATION;

		private int AP_ATTR_LEVEL_MAX;

		private List<long> SpStaminaItems;

		private static List<long> chapters;

		public Dictionary<long, long> InstanceSetToFrontInstance
		{
			get
			{
				return null;
			}
		}

		public int GetCoreInstanceAndChestTotal()
		{
			return 0;
		}

		public int GetCoreInstanceInterval()
		{
			return 0;
		}

		public int GetCoreInstanceNum()
		{
			return 0;
		}

		public int GetCoreInstanceCumulation()
		{
			return 0;
		}

		public int GetActivityAttrLevelMax()
		{
			return 0;
		}

		public static GameDataHelper GetInstance()
		{
			return null;
		}

		private void InitData()
		{
		}

		public List<ObservableSingleItem> GetAllSpStaminaItems()
		{
			return null;
		}

		public int GetMaxStar(long id)
		{
			return 0;
		}

		public int GetMaxRank(long id)
		{
			return 0;
		}

		public List<TypeCsvServantWeapon> GetServantWeaponByServantID(long id)
		{
			return null;
		}

		public TypeCsvServantImage GetServantImageByIdAndSerial(long id, int serial)
		{
			return null;
		}

		public TypeCsvKrGoods GetKrGood(long id)
		{
			return null;
		}

		public TypeCsvTwGoods GetTwGood(long id)
		{
			return null;
		}

		public long GetServantByPieceItemID(long id)
		{
			return 0L;
		}

		public List<long> GetComposeServantWeaponNeedItem()
		{
			return null;
		}

		public Dictionary<long, List<long>> GetAllAp5RoundTypeToBuffs()
		{
			return null;
		}

		public List<long> GetPromoteServantWeaponNeedItem()
		{
			return null;
		}

		private void InitAttributeValues()
		{
		}

		public int GetInstanceIndexByInstanceID(long id)
		{
			return 0;
		}

		private int findInstanceInInstanceStruct(long source, long target, int currentIndex, int instance_type)
		{
			return 0;
		}

		public static GlobalEnum.PackageTypes GetPackageType(long id)
		{
			return default(GlobalEnum.PackageTypes);
		}

		public static object[] GetServantEquipComposeEquipNum(string ID)
		{
			return null;
		}

		public int GetInstanceNumberInInstanceSet(long id)
		{
			return 0;
		}

		public double[] GetAttributeValues()
		{
			return null;
		}

		public int GetInstanceSetIndexByInstanceID(long id)
		{
			return 0;
		}

		public static object[] GetServantEquipItemComposeNum(string ID)
		{
			return null;
		}

		public static object[] GetEquipDetailByID(string ID, int type = 0)
		{
			return null;
		}

		public static object[] GetEquipCompoundElements(long ID)
		{
			return null;
		}

		public static bool IsValid(object[] objs, int max = 0)
		{
			return false;
		}

		public static object[] GetAchieveRewardEquip(long id)
		{
			return null;
		}

		public static int[] GetEquipmentProperties(long[] ID)
		{
			return null;
		}

		public static long[] GetSVImageProperties(long svID)
		{
			return null;
		}

		public static long[] GetMercenaryServantImageProperties(MercenaryServant info)
		{
			return null;
		}

		public static long GetLevelLimit(string servantID, int level)
		{
			return 0L;
		}

		public static object[] GetAchieveRewardItem(long id)
		{
			return null;
		}

		public static long GetSkillId(long servantId, int skillIndex)
		{
			return 0L;
		}

		public static int[] GetFavorabilityProperties(long ID, int startLevel, int endLevel)
		{
			return null;
		}

		public static string[] GetFavorabilityPropertiesAdvanced(long ID, int startLevel, int endLevel)
		{
			return null;
		}

		public static int GetFavorabilityWeaponAttack(long ID, int startLevel, int endLevel)
		{
			return 0;
		}

		public static object[] GetFinishAchieveDetailByID(long ID)
		{
			return null;
		}

		public static string[] GetAccessableLevels(long ID)
		{
			return null;
		}

		public static string[] GetAccessableMainTypeLevels(long ID)
		{
			return null;
		}

		public static bool HaveNextChapterProgress(long chapterID)
		{
			return false;
		}

		public static bool IsInstanceRepeatable(long ID)
		{
			return false;
		}

		public static List<long> GetMainChapters()
		{
			return null;
		}

		public static int[] GetServantSpellAddAttribute(long ServantID, int Rank, int ActiveLevel, int Passive1Level)
		{
			return null;
		}

		public static List<DrawResultData> getAchievementOrQuestRewardList(long currentID)
		{
			return null;
		}

		public static long CanEquipOn(long servantID, int equipIndex)
		{
			return 0L;
		}

		public static List<LotteryLootData> GetInstanceLoots(long instanceId)
		{
			return null;
		}

		public static long GetCoreLootId(int playerLevel, int coreLevelIndex)
		{
			return 0L;
		}

		public static List<long> GetAP5ConfirmBuffByRoundType(int roundType)
		{
			return null;
		}

		public static List<long> GetAP5SpecialConfirmBuffe()
		{
			return null;
		}
	}
}
