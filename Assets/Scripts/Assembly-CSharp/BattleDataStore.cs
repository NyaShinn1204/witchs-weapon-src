using System.Collections.Generic;
using Combatmod;
using LitJson;

public class BattleDataStore
{
	public const int ARGUMENT_COUNT_LONG = 3;

	public const int ARGUMENT_COUNT_ALL = 30;

	public const int TRIGGER_COUNT = 4;

	public const int SPECIAL_TRIGGER_COUNT = 2;

	private int CHARACTER_NORMAL_ATTACK_MAX_NUM;

	public PropertiesVO heroProperty;

	public HeroVO hero;

	public Dictionary<string, MonsterVO> monsters;

	public string levelJson;

	private static BattleDataStore instance;

	private Dictionary<long, BuffProperty> buffDic;

	private Dictionary<long, TriggerVO> triggerDic;

	private Dictionary<long, Dictionary<string, object>> argumentsDic;

	private Dictionary<long, MonsterType> typeDic;

	public Dictionary<long, ServantVO> servantsDic;

	public Dictionary<long, AgentVO> agentDic;

	private Dictionary<long, BehaviorTreeArgument> treeDic;

	public Dictionary<string, long> btTreeDic;

	public float HeroBaseHP;

	private SkillTPLManager skillTplManager;

	private Dictionary<long, float> speedDic;

	public ObjectInstanceCreater creater;

	private MobRelationSelector heroMobSelector;

	public float averageServantLevel;

	public float averageMobLevel;

	public GuildCache cache;

	public bool isrelife__;

	public HashSet<string> cacheMonster;

	public HashSet<string> cacheBTTree;

	private long cacheMobID;

	private int cacheType;

	private int cacheLevel;

	private bool isLoadComplete;

	private BattleDataStore()
	{
	}

	public Dictionary<long, BuffProperty> GetBuffDic()
	{
		return null;
	}

	private void GetBTTree()
	{
	}

	public void InitBTTreePool(Dictionary<string, int> MobMaxAppearacneList)
	{
	}

	public static BattleDataStore GetInstance()
	{
		return null;
	}

	private void SetCharacterConst(PropertiesVO property, int type)
	{
	}

	public static string GetMobUUID(long id, int type, int level)
	{
		return null;
	}

	private string GetGroupPropertyName(int typeID)
	{
		return null;
	}

	public void StoreRandomConst(JsonData data)
	{
	}

	public HeroVO GetHeroVO()
	{
		return null;
	}

	public ServantVO GetServant(long cardID)
	{
		return null;
	}

	public BuffProperty GetBuffByID(long buffID)
	{
		return null;
	}

	public MonsterVO GetMonsterByID(string monsterId, bool useUUID = false)
	{
		return null;
	}

	private MonsterVO cloneMonsterVO(MonsterVO mon, bool useUUID)
	{
		return null;
	}

	private MonsterType GetGroupByID(long groupID)
	{
		return null;
	}

	public TriggerVO GetTrigger(long id)
	{
		return null;
	}

	public AgentVO GetAgent(long id)
	{
		return null;
	}

	public BehaviorTreeArgument GetTreeArgu(long id)
	{
		return null;
	}

	public void PatchClientServantInfo()
	{
	}

	public void ClearData()
	{
	}

	private static int ParseInt(JsonData data)
	{
		return 0;
	}

	private static bool ParseIntBool(JsonData data)
	{
		return false;
	}

	private static long ParseLong(JsonData data)
	{
		return 0L;
	}

	private static float ParseFloat(JsonData data)
	{
		return 0f;
	}

	public void StoreBasket(Basket basket)
	{
	}

	public void StoreRoleCombatInfo(RoleCombatInfoProto rcInfo)
	{
	}

	private void SaveEffArgu(EffectArgumentInfo info)
	{
	}

	private void SaveTreeArgu(BehaviorTreeArgumentInfo info)
	{
	}

	private void SaveSpell(SpellInfo info)
	{
	}

	private TriggerVO SaveTrigger(TriggerInfo info)
	{
		return null;
	}

	private BuffProperty SaveBuff(BuffInfo info)
	{
		return null;
	}

	private void CachePreloadingMob(BuffProperty buff)
	{
	}

	private void SaveMobType(MobTypeInfo info)
	{
	}

	private void SaveMob(MobInfo info)
	{
	}

	private void SaveSingleMob(MobInfo info, int powerRank, MonsterType typeInfo)
	{
	}

	private void SaveAgent(AgentInfo info)
	{
	}

	private void SaveServant(ServantCombatInfo info)
	{
	}

	private void PreloadingOtherEffects()
	{
	}

	public Dictionary<long, ServantVO> GetServatns()
	{
		return null;
	}

	public ServantVO GetServantByWeaponID(long id)
	{
		return null;
	}

	private void SaveMobBTPool(Dictionary<string, int> dic)
	{
	}

	public string GetBTPath(string monsterID)
	{
		return null;
	}

	private void SaveHeroMobBTPool(Dictionary<string, int> dic)
	{
	}

	private Dictionary<string, int> GenHeroMobDic()
	{
		return null;
	}

	public MonsterVO __GetMob__(string id)
	{
		return null;
	}

	public void PlaySound(MonsterVO vo, string event_type)
	{
	}

	private string PatchServantID(string id)
	{
		return null;
	}

	public float GetServantMaxATK(int type)
	{
		return 0f;
	}

	private void ConvertSpeedConstToDic()
	{
	}

	private void SaveToDic(string val)
	{
	}

	private string[] SplitValue(string val)
	{
		return null;
	}
}
