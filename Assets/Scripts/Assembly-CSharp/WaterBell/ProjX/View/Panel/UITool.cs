using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public static class UITool
	{
		public enum RankColors
		{
			White = 1,
			Green = 2,
			Blue = 3,
			Violet = 4,
			Orange = 5
		}

		public enum LootDisplayType
		{
			PackageIcon = 0,
			Num = 1
		}

		private static HashSet<long> canUnlockStory;

		private static readonly HashSet<GlobalEnum.ResType> soleTypeSet;

		private static readonly DateTime utcStart;

		private static readonly Dictionary<string, string> timeSpanStrDict;

		private static int uiMainLayer;

		private static GameObject disabledInputMask;

		private static readonly Dictionary<int, string> servantStyleDict;

		private static Dictionary<int, Color> rankLevelTextColor;

		private static Dictionary<int, string> simpleChineseNumDict;

		private static Dictionary<int, string> simpleChineseShortDigitsDict;

		private static Dictionary<int, string> simpleChineseDigitsDict;

		private const string numKeyPrefix = "Num_";

		private static Dictionary<long, string> AttributeIconDict;

		private static Dictionary<long, string> AttributeIextDict;

		private static List<RankColors> rankLevelStep;

		private static Dictionary<int, LootDisplayType> lootDisplayTypeDict;

		private static Dictionary<int, string> rareDict;

		private static readonly Dictionary<long, int> itemTypeNameDict;

		private static readonly Dictionary<int, long> itemSubTypeNameDict;

		public static bool IsJpPlatform()
		{
			return false;
		}

		public static bool CanShowShare()
		{
			return false;
		}

		public static bool IsKrPlatform()
		{
			return false;
		}

		public static string GetActivityGamesDataDesc(long id)
		{
			return null;
		}

		public static List<LotteryLootData> GetLootFromSpecialServiceCsv(long id)
		{
			return null;
		}

		public static string LoadHelpText(string text)
		{
			return null;
		}

		public static TypeCsvRank GetRankTD(int activityGameSerial, long levelType, int section)
		{
			return null;
		}

		public static ActivityGameDataPropInfo GetActivityGameDataInfo(long id, int propID)
		{
			return default(ActivityGameDataPropInfo);
		}

		public static List<LotteryLootData> GetReward(long id)
		{
			return null;
		}

		public static string GetRichText(string text, Color color)
		{
			return null;
		}

		public static string GetRichTextColorStart(Color color)
		{
			return null;
		}

		public static string GetRichTextColorEnd()
		{
			return null;
		}

		public static string GetActivityMobModulusDesc(string mobEnhance)
		{
			return null;
		}

		public static string GetActivityMobModulusIcon(string mobEnhance)
		{
			return null;
		}

		public static Vector2 GetCirclePos(Vector2 center, float angle, float radius)
		{
			return default(Vector2);
		}

		public static bool PlayNewStoryTipsAnim(int storyGroupType = 1)
		{
			return false;
		}

		public static void SaveCanUnlockStory()
		{
		}

		public static int GetCharacterTotalExp(int level, int exp)
		{
			return 0;
		}

		public static DateTime GetDateTime(long csvTimeValue)
		{
			return default(DateTime);
		}

		public static UniWebView OpenWeb(string url)
		{
			return null;
		}

		public static List<TypeCsvServantWeapon> GetServantWeaponTable()
		{
			return null;
		}

		public static T GetPanel<T>(string prefabPath, AssetsManager.AssetsType type) where T : UIPanelSingle
		{
			return null;
		}

		public static void Unload(GUtilListenerEvent sEvent)
		{
		}

		public static bool IsSoleItem(GlobalEnum.ResType type)
		{
			return false;
		}

		public static void DestroyChildren(GameObject go)
		{
		}

		public static DateTime GetResetTime()
		{
			return default(DateTime);
		}

		public static DateTime TimeStamp2DateTime(long timeStamp)
		{
			return default(DateTime);
		}

		public static long DateTime2TimeStamp(DateTime time)
		{
			return 0L;
		}

		public static string GetTimeSpanStr(long sec)
		{
			return null;
		}

		public static long Sec2Ticks(long sec)
		{
			return 0L;
		}

		public static string GetTimeSpanStr(TimeSpan ts)
		{
			return null;
		}

		public static int GetUIMainLayer()
		{
			return 0;
		}

		public static void Refresh(MonoBehaviour mono)
		{
		}

		public static string GetGameObjectPath(Transform obj, bool includeSelf = true)
		{
			return null;
		}

		public static string GetGameObjectPath(Transform child, Transform parent, bool includeSelf = true, bool includePrefix = true)
		{
			return null;
		}

		public static void DisabledInput(float duration = 1f)
		{
		}

		public static void EnabledInput()
		{
		}

		public static string GetServantStyle(int style)
		{
			return null;
		}

		public static Color ParseHex2Color(string hex)
		{
			return default(Color);
		}

		public static Color GetRankLevelTextColor(int level)
		{
			return default(Color);
		}

		public static string GetNumText(int num)
		{
			return null;
		}

		public static string GetSimpleChineseNumText(int num)
		{
			return null;
		}

		public static string GetAttributeIext(long attributeId)
		{
			return null;
		}

		public static string GetAttributeIcon(long attributeId, string prefix = "Attribute_Icon_", string suffix = "_01")
		{
			return null;
		}

		public static string GetRankNameIcon(int rank)
		{
			return null;
		}

		public static LootDisplayType GetLootDisplayType(int type)
		{
			return default(LootDisplayType);
		}

		public static TypeCsvServantImage GetServantImageTableData(long servantID, int serial)
		{
			return null;
		}

		public static GameObject GetServantDynamicImage(long servantID, bool isDefaultImage = true, int serial = 1)
		{
			return null;
		}

		public static Texture GetServantImage(long servantID, bool isDefaultImage = true, int serial = 1)
		{
			return null;
		}

		public static void UnloadServantImage(long servantID, bool isDefaultImage = true, int serial = 1)
		{
		}

		public static Texture GetServantImageBg(long servantID, int serial = 1)
		{
			return null;
		}

		public static string GetServantImagePath(long servantID, int serial, string suffix)
		{
			return null;
		}

		public static RankColors GetRankColor(int rank)
		{
			return default(RankColors);
		}

		public static int GetRankLevel(int rank)
		{
			return 0;
		}

		public static string GetWeaponType(int wepaonType)
		{
			return null;
		}

		public static int GetServantImageSerial(long svID, long rid)
		{
			return 0;
		}

		public static string GetWeaponMiniIcon(long weaponID, bool isAwake = false)
		{
			return null;
		}

		public static string GetWeaponTypeIcon(int wepaonType)
		{
			return null;
		}

		public static string GetWeaponPrefab(long weaponID, int promoteLevel)
		{
			return null;
		}

		public static string GetRankIcon(int rank)
		{
			return null;
		}

		public static string GetRankPrepareHead(int rank)
		{
			return null;
		}

		public static List<LotteryLootData> GetServantResolve(LotteryLootData lootData)
		{
			return null;
		}

		public static List<LotteryLootData> GetWeaponResolve(LotteryLootData lootData)
		{
			return null;
		}

		public static void SetHeroInteractiveState(HeroSwitchSkin skin, bool isActive)
		{
		}

		public static int GetWeaponIndex(long weaponID)
		{
			return 0;
		}

		public static string GetWeaponRareIcon(int rare, string prefix = "Icon_Weapon_")
		{
			return null;
		}

		public static string GetRareStr(int rare)
		{
			return null;
		}

		public static int GetRare(string rareStr)
		{
			return 0;
		}

		public static string GetWeaponQulityBg(int rare)
		{
			return null;
		}

		public static string GetWeaponIcon(long weaponID, int weaponSkinIndex)
		{
			return null;
		}

		public static string GetWeaponImage(long weaponID, int weaponSkinIndex)
		{
			return null;
		}

		public static string GetWeaponSuffix(int weaponSkinIndex)
		{
			return null;
		}

		public static Camera GetMainCamera()
		{
			return null;
		}

		public static UIRoot GetMainUIRoot()
		{
			return null;
		}

		public static TimeSpan Sec2TimeSpan(long sec)
		{
			return default(TimeSpan);
		}

		public static void TextureFillScreen(UITexture tex)
		{
		}

		public static void Label2ImageLabel(Transform container, long value, string prefix)
		{
		}

		public static string GetItemTypeName(long itemID)
		{
			return null;
		}

		public static bool TryPlayLootAnim(LotteryLootData lootData, Action onComplete = null)
		{
			return false;
		}

		public static List<LotteryLootData> GetLootDataList(ModelCollection<DrawResultData> loots, bool isRandomSort = false)
		{
			return null;
		}

		public static List<LotteryLootData> GetLootDataList(List<DrawResultData> loots, bool isRandomSort = false)
		{
			return null;
		}

		public static List<LotteryLootData> GetLootDataList(List<DrawResultData> weapons, List<DrawResultData> loots, bool isRandomSort = false, RepeatedField<LootObject> OriginalLoots = null)
		{
			return null;
		}

		public static List<LotteryLootData> GetLootDataList(ModelCollection<DrawResultData> weaponCollection, ModelCollection<DrawResultData> lootCollection, bool isRandomSort = false, RepeatedField<LootObject> OriginalLoots = null)
		{
			return null;
		}

		public static int GetServantPieceCount(LotteryLootData lootData)
		{
			return 0;
		}

		public static string GetActivityDesc(long activityID)
		{
			return null;
		}

		public static string GetActivityIcon(long activityID)
		{
			return null;
		}

		public static List<LotteryLootData> GetItemSets(long itemID)
		{
			return null;
		}
	}
}
