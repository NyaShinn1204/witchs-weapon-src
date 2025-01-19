using System.Collections.Generic;

public class ManagerCsv
{
	public enum Language
	{
		cn = 0,
		tw = 1,
		jp = 2,
		kr = 3,
		en = 4
	}

	public enum SDKPlatform
	{
		android_taptap = 0,
		android_tw = 1,
		android_jp = 2,
		android_kr_one = 3,
		android_kr_google = 4,
		android_kr_one_test = 5,
		android_kr_google_test = 6,
		android_jp_test = 7,
		ios_taptap = 8,
		ios_tw = 9,
		ios_jp = 10,
		ios_jp_test = 11,
		android_pc_dmm_jp = 12,
		android_pc_dmm_jp_test = 13,
		ios_kr = 14,
		ios_kr_test = 15,
		android_en = 16,
		ios_en = 17,
		android_tw_test = 18,
		android_en_test = 19,
		ios_tw_test = 20,
		ios_en_test = 21
	}

	public const string LISTENER_CHANGE_LANGUAGE = "CHANGE_LANGUAGE";

	private static int _language;

	private static Dictionary<string, UtilCsvReader> _csvReader;

	private static Dictionary<string, object> _data;

	private static Dictionary<object, object> _dataLanguage;

	private static Dictionary<string, object> _dataLanguageStatic;

	private static bool _init;

	private static string[] _file_path_list;

	private static Dictionary<long, string> mapIDtoSceneName;

	private static ManagerCsv _instance;

	private Dictionary<string, CampAttrInfo> revertedCampCombat;

	private HashSet<string> _SUB_TABLE;

	public static int CID
	{
		get
		{
			return 0;
		}
	}

	public static SDKPlatform sdkPlatform
	{
		get
		{
			return default(SDKPlatform);
		}
	}

	public static Language languageDefault
	{
		get
		{
			return default(Language);
		}
	}

	public static Language language
	{
		get
		{
			return default(Language);
		}
		set
		{
		}
	}

	public static string languageDefaultStr
	{
		get
		{
			return null;
		}
	}

	public static string languageStr
	{
		get
		{
			return null;
		}
	}

	public static bool IsInit
	{
		get
		{
			return false;
		}
	}

	public static Dictionary<long, string> MapIDtoSceneName
	{
		get
		{
			return null;
		}
	}

	public static int channel_group
	{
		get
		{
			return 0;
		}
	}

	public static ManagerCsv GetInstance()
	{
		return null;
	}

	public static void Reload()
	{
	}

	private void init()
	{
	}

	private void InitLanguageDictionaryStatic<T>() where T : TypeCsvDictionaryStatic_cn, new()
	{
	}

	private void InitLanguageDictionary<T>() where T : TypeCsvDictionary_cn, new()
	{
	}

	public TypeCsvMobPointSound GetMobPointSound(string sPrefabName, string sPoint)
	{
		return null;
	}

	public TypeCsvAchievement GetAchievement(long sID)
	{
		return null;
	}

	public Dictionary<long, TypeCsvAchievement> GetAchievementDictionary()
	{
		return null;
	}

	public TypeCsvBuff GetBuff(long sID)
	{
		return null;
	}

	public TypeCsvCharacterLevelInfo GetCharacterLevelInfo(long sID)
	{
		return null;
	}

	public TypeCsvConstant GetConstant(string sID)
	{
		return null;
	}

	public TypeCsvCoreInstanceLootInfo GetCoreInstanceLootInfo(long sID)
	{
		return null;
	}

	public TypeCsvDiamond GetDiamond(long sID)
	{
		return null;
	}

	public List<TypeCsvVictoryFailureConditions> GetVictoryFailureConditionTable()
	{
		return null;
	}

	public string GetClientPlatformConstant(string sID)
	{
		return null;
	}

	public List<TypeCsvBattleEnvironment> GetBuffBattleEnvTable()
	{
		return null;
	}

	public string GetName(long sID)
	{
		return null;
	}

	public string GetNameByCN(string sName)
	{
		return null;
	}

	public string GetNameStatic(string sText)
	{
		return null;
	}

	public bool HasNameStatic(string sText)
	{
		return false;
	}

	public TypeCsvEverydayGames GetEverydayGames(long sID)
	{
		return null;
	}

	public List<TypeCsvInstance> GetInstanceTable()
	{
		return null;
	}

	public List<TypeCsvAtlasPool> GetAtlasTable()
	{
		return null;
	}

	public TypeCsvInstance GetInstance(long sID)
	{
		return null;
	}

	public TypeCsvRune GetRune(long sID)
	{
		return null;
	}

	public TypeCsvRuneBreak GetRuneBreak(long sID)
	{
		return null;
	}

	public TypeCsvSuit GetSuit(long sID)
	{
		return null;
	}

	public List<TypeCsvInstance> GetInstanceAll(long sChapter)
	{
		return null;
	}

	public List<TypeCsvKrGoods> GetKrGoodsAll()
	{
		return null;
	}

	public List<TypeCsvTwGoods> GetTwGoodsAll()
	{
		return null;
	}

	public TypeCsvInstanceExtraTarget GetInstanceExtraTarget(long sID)
	{
		return null;
	}

	public TypeCsvInstanceMobList GetInstanceMobList(long sID)
	{
		return null;
	}

	public List<TypeCsvInstanceMobList> GetInstanceMobListAll()
	{
		return null;
	}

	public TypeCsvVictoryFailureConditions GetVictoryFailureConditions(long sID)
	{
		return null;
	}

	public TypeCsvInstanceSet GetInstanceSet(long sID)
	{
		return null;
	}

	public List<TypeCsvInstanceSet> GetAllInstanceSet()
	{
		return null;
	}

	public TypeCsvEmblem GetEmblem(long sID)
	{
		return null;
	}

	public List<TypeCsvEmblem> GetAllEmblem()
	{
		return null;
	}

	public List<TypeCsvInstanceSet> GetDailyInstanceSet()
	{
		return null;
	}

	public List<TypeCsvInvite> GetAllInvite()
	{
		return null;
	}

	public TypeCsvInstanceStructure GetInstanceStructure(long sID)
	{
		return null;
	}

	public TypeCsvItem GetItem(long sID)
	{
		return null;
	}

	public List<TypeCsvItem> GetAllItemData()
	{
		return null;
	}

	public TypeCsvItemClient GetItemClient(long sID)
	{
		return null;
	}

	public List<TypeCsvItemClient> GetItemClientList()
	{
		return null;
	}

	public TypeCsvActivityGamesBuff GetActivityGamesBuff(long sID)
	{
		return null;
	}

	public TypeCsvMob GetMob(long sID)
	{
		return null;
	}

	public Dictionary<long, TypeCsvMob> GetMobDictionary()
	{
		return null;
	}

	public TypeCsvMobPointSound GetMobPointSound(long sID)
	{
		return null;
	}

	public TypeCsvServant GetServant(long sID)
	{
		return null;
	}

	public List<TypeCsvServant> GetAllServant()
	{
		return null;
	}

	public Dictionary<long, TypeCsvServant> GetServantDictionary()
	{
		return null;
	}

	public TypeCsvServantClient GetServantClient(long sID)
	{
		return null;
	}

	public List<TypeCsvServantClient> GetServantClientList()
	{
		return null;
	}

	public TypeCsvServantEquip GetServantEquip(long sID)
	{
		return null;
	}

	public TypeCsvServantEquipClient GetServantEquipClient(long sID)
	{
		return null;
	}

	public TypeCsvServantFavorability GetServantFavorability(long sID)
	{
		return null;
	}

	public TypeCsvServantLevelInfo GetServantLevelInfo(long sID)
	{
		return null;
	}

	public TypeCsvServantRankInfo GetServantRankInfo(long sID)
	{
		return null;
	}

	public TypeCsvServantStarInfo GetServantStarInfo(long sID)
	{
		return null;
	}

	public TypeCsvServantStarAttr GetServantStarAttr(long sID)
	{
		return null;
	}

	public TypeCsvActivity GetActivity(long sID)
	{
		return null;
	}

	public List<TypeCsvActivity> GetActivitys(long base_id)
	{
		return null;
	}

	public TypeCsvSound GetSound(long sID)
	{
		return null;
	}

	public List<TypeCsvSound> GetSoundTable()
	{
		return null;
	}

	public TypeCsvSpell GetSpell(long sID)
	{
		return null;
	}

	public TypeCsvSpecialService GetTypeCsvSpecialService(long sID)
	{
		return null;
	}

	public List<TypeCsvSpecialService> GetAllTypeCsvSpecialService()
	{
		return null;
	}

	public List<TypeCsvRoleSummon> GetSpellOtherAll()
	{
		return null;
	}

	public TypeCsvStoryGroup GetStoryGroup(long sID)
	{
		return null;
	}

	public List<TypeCsvStoryGroup> GetStoryGroupList()
	{
		return null;
	}

	public TypeCsvStory GetStory(long sID)
	{
		return null;
	}

	public List<TypeCsvStory> GetAllStory()
	{
		return null;
	}

	public TypeCsvVip GetVip(long sID)
	{
		return null;
	}

	public TypeCsvEffect GetEffect(long sID, string tail = "1")
	{
		return null;
	}

	public TypeCsvAttributeValue GetAttributeValue(long sID)
	{
		return null;
	}

	public List<TypeCsvServantImage> GetServantImageTable()
	{
		return null;
	}

	public Dictionary<long, TypeCsvServantImage> GetServantImageDictionary()
	{
		return null;
	}

	public TypeCsvServantWeapon GetServantWeapon(long sID)
	{
		return null;
	}

	public List<TypeCsvServantWeapon> GetServantWeaponTable()
	{
		return null;
	}

	public Dictionary<long, TypeCsvServantWeapon> GetServantWeaponDictionary()
	{
		return null;
	}

	public TypeCsvServantWeaponAttr GetServantWeaponAttr(long sID)
	{
		return null;
	}

	public TypeCsvCoreInstance GetCoreInstance(long sID)
	{
		return null;
	}

	public TypeCsvDiscount GetDiscount(long sID)
	{
		return null;
	}

	public TypeCsvFashion GetFashion(long sID)
	{
		return null;
	}

	public List<TypeCsvFashion> GetFashionTable()
	{
		return null;
	}

	public TypeCsvServantCfg GetServantCfg(long sID)
	{
		return null;
	}

	public TypeCsvGoods GetGoods(long sID)
	{
		return null;
	}

	public TypeCsvInstanceTarget GetInstanceTarget(long sID)
	{
		return null;
	}

	public TypeCsvRuneColor GetRuneColor(long sID)
	{
		return null;
	}

	public TypeCsvRuneType GetRuneType(long sID)
	{
		return null;
	}

	public TypeCsvRuneLevel GetRuneLevel(long sID)
	{
		return null;
	}

	public TypeCsvServantFavorGrade GetServantFavorGrade(long sID)
	{
		return null;
	}

	public TypeCsvServantImage GetServantImage(long sID)
	{
		return null;
	}

	public TypeCsvShop GetShop(long sID)
	{
		return null;
	}

	public TypeCsvShopSet GetShopSet(long sID)
	{
		return null;
	}

	public TypeCsvOP GetOP(long sID)
	{
		return null;
	}

	public List<TypeCsvOP> GetOPTable()
	{
		return null;
	}

	public TypeCsvShopBigSet GetShopBigSet(long sID)
	{
		return null;
	}

	public TypeCsvInstallation GetInstallation(long sID = 1L)
	{
		return null;
	}

	public List<TypeCsvLessonTrigger> GetLessonTriggerAll()
	{
		return null;
	}

	public TypeCsvKanban GetKanban(long sID)
	{
		return null;
	}

	public TypeCsvSourceTips GetSourceTips(long sID)
	{
		return null;
	}

	public TypeCsvChallenge GetChallenge(long sID)
	{
		return null;
	}

	public TypeCsvCamp GetCamp(long sID)
	{
		return null;
	}

	public List<TypeCsvViewFI> GetViewFI(string sAnimator, string sState)
	{
		return null;
	}

	public void GetViewFI4Fast()
	{
	}

	public List<TypeCsvViewFI> GetViewFI4Animator(string sAnimator)
	{
		return null;
	}

	public TypeCsvBattleEnvironment GetBattleEnvironment(long sID)
	{
		return null;
	}

	public TypeCsvRank GetRank(long sID)
	{
		return null;
	}

	public List<TypeCsvRank> GetAllRank()
	{
		return null;
	}

	public TypeCsvHead GetHead(long sID)
	{
		return null;
	}

	public List<TypeCsvHead> GetAllHead()
	{
		return null;
	}

	public TypeCsvHeadBox GetHeadBox(long sID)
	{
		return null;
	}

	public List<TypeCsvHeadBox> GetAllHeadBox()
	{
		return null;
	}

	public List<TypeCsvTitle> GetAllTitle()
	{
		return null;
	}

	public List<TypeCsvKanban> GetAllBordAction()
	{
		return null;
	}

	public List<TypeCsvActivityGameData> GetAllActivityGameData()
	{
		return null;
	}

	public TypeCsvActivityGameData GetActivityGameData(long sID)
	{
		return null;
	}

	public Dictionary<long, TypeCsvActivityGameData> GetActivityGameDataDictionary()
	{
		return null;
	}

	public TypeCsvActivityGames GetActivityGames(long sID)
	{
		return null;
	}

	public TypeCsvMonthCard GetMonthCard(long sID)
	{
		return null;
	}

	public TypeCsvServantWeaponPromote GetServantWeaponPromote(long sID)
	{
		return null;
	}

	public TypeCsvTitle GetTitle(long sID)
	{
		return null;
	}

	public TypeCsvKanban GetBordAction(long sID)
	{
		return null;
	}

	public TypeCsvGuildModulus GetGuildModulus(long sID)
	{
		return null;
	}

	public List<TypeCsvInteraction> GetAllInteraction()
	{
		return null;
	}

	public TypeCsvInteraction GetInteraction(long sID)
	{
		return null;
	}

	public Dictionary<long, TypeCsvInteraction> GetInteractionDictionary()
	{
		return null;
	}

	public TypeCsvCV GetCharVoice(long sID)
	{
		return null;
	}

	public TypeCsvMainRoleCharVoice GetMainRoleCharVoice(long sID)
	{
		return null;
	}

	public TypeCsvMobHandbook GetMobHandbook(string sModel)
	{
		return null;
	}

	public Dictionary<int, TypeCsvFightSound> GetFightSoundDictionary()
	{
		return null;
	}

	public TypeCsvChangeFightSound GetChangeFightSound(long sID)
	{
		return null;
	}

	public TypeCsvCameraControlMap GetCameraControlMap(string sID)
	{
		return null;
	}

	private void InitShopStructureTable()
	{
	}

	public TypeCsvShopStructure GetShopStructure(string sID)
	{
		return null;
	}

	public TypeCsvShopStructure GetShopStructureIDByShopBigSetID(long sID)
	{
		return null;
	}

	public List<TypeCsvCampCombat> GetCampCombatAll()
	{
		return null;
	}

	public Dictionary<string, CampAttrInfo> GetCampCombatDict()
	{
		return null;
	}

	public string CombineCampCombatDictKey(int combatserial, int campCombatType, long servantCardID)
	{
		return null;
	}

	public List<TypeCsvUILoadingPic> GetUILoadingPicList()
	{
		return null;
	}

	public List<Dictionary<string, string>> GetPublicity(int sID)
	{
		return null;
	}

	public List<Dictionary<string, string>> GetPublicityMath(int sID)
	{
		return null;
	}

	public TypeCsvMapPoint GetMapPoint(long sID)
	{
		return null;
	}

	public TypeCsvClientGeneralConfig GetClientGeneralConfig(string sID)
	{
		return null;
	}

	public TypeCsvPersonalDraw GetPersonalDraw(long sID)
	{
		return null;
	}

	public Dictionary<long, TypeCsvPlayerCV> GetPlayerCVAll()
	{
		return null;
	}

	private List<T> GetTableByCID<T>(string sTable, object[] sMainKey) where T : new()
	{
		return null;
	}

	private T GetDataByCID<T>(string sTable, params object[] objs) where T : new()
	{
		return default(T);
	}

	private void FastReadTableData<T>(string sTableName, string sKey = "ID") where T : new()
	{
	}
}
