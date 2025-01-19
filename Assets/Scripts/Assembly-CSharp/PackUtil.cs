using System.Collections.Generic;
using UnityEngine;

public static class PackUtil
{
	public static BasePack CreateDamagePack(Entity attacker, Entity defencer, NumericParam param, int type, bool isSkill, bool isCommonAtk, float damageRate, int damageTag, int typeTag, int packLevel, int damage = 0, bool isCombine = false, long cSound = 0L, long hitSound = 0L, bool isMustHit = false, bool isNotCrit = false, BuffSourcePropDTO dto = null)
	{
		return null;
	}

	public static void StatsDamage(DamagePack pack)
	{
	}

	public static BasePack CreateHealPack(Entity attacker, Entity defencer, NumericParam param, bool isSkill, int packLevel, float healRate, int healtag, int overhealtype = 0, float specialValue = 0f, bool isHit = false, bool issteal = false, bool isnoshow = false, BuffSourcePropDTO buffSourceVO = null)
	{
		return null;
	}

	public static BasePack CreateBuffPack(long[] ids, int[] layers, int level, Entity target, Entity source, BuffSourcePropDTO buffSourceVO, int packLevel, bool isHit = false, BuffDefined buffdefined = null)
	{
		return null;
	}

	public static BasePack CreateDispelPack(List<long> buffIDs, List<int> layers, Entity source, Entity target, List<int> types, int pasitiveType, int limit, int packLevel, bool isforce, bool isremove, bool isHit = false)
	{
		return null;
	}

	public static BasePack CreateTauntPack(Entity entity, Entity target, int packLevel, bool isHit = false)
	{
		return null;
	}

	public static BasePack CreateVectorPack(Entity target, float maxDuration, Vector3 direction, float speed, int packLevel, int stackType, Skill skill = null, bool isHit = false)
	{
		return null;
	}

	public static void CreateAgent(int maxNum, long[] ids, int[] modeArray, string[] typeArray, Entity master, Skill skill, int layer, int flashTimeMs = 0, int[] pos = null, int[] faceto = null)
	{
	}

	private static AgentEntity CreateSingleAgent(long id, int maxNum, Entity master, int inheritMode, string inheritType, Skill sourceSkill, int layer, int flashTimeMs = 0, int[] setpos = null, int[] faceto = null)
	{
		return null;
	}

	private static bool IsShowAgent(string motionid)
	{
		return false;
	}

	public static void ThrowToTarget(Entity unit, BasePack pack)
	{
	}

	private static PackParam CalulateParam(int type, bool isSkill, bool isDamage, bool isCommonAtk, Entity attacker, Entity defencer, int packLevel, bool isHit = false, int damageTag = 0, BuffSourcePropDTO dto = null, NumericParam param = null)
	{
		return null;
	}

	private static float CheckCritHighBuffs(Entity entity, float FPCR, bool isCommonAtk)
	{
		return 0f;
	}

	private static float[] CheckCritStarBuffs(Entity entity, float FPCR, float FMCR, int type, int damagetag)
	{
		return null;
	}

	private static float CheckDodgeStarBuffs(Entity entity, float FMR, float FDR)
	{
		return 0f;
	}

	private static PackParam CreatePackParamByNonDamageType(Entity attacker, Entity defencer, int packLevel, bool isHit, PropertiesVO attackerProp, int attackerLevel)
	{
		return null;
	}

	private static PackParam CreatePackParamByCommonSkill(int type, float FMR, float FDR, float FCR)
	{
		return null;
	}

	private static PackParam CreatePackParamByNullCommonSkill(int type, float FCR)
	{
		return null;
	}

	private static PackParam CreatePackParamByBuff()
	{
		return null;
	}

	public static void ShowDamageInfo(Entity entity, DamagePack pack, bool isImmue = false, bool isAbsorb = false)
	{
	}

	public static void ShowNonDamageInfo(BasePack pack, Entity target)
	{
	}
}
