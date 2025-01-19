public class BuffProperty
{
	public const int CONDITION_ADD_GHOST = 1;

	public const int CONDITION_ADD_PHYSIC_IMMUNE = 2;

	public const int CONDITION_ADD_MAGIC_IMMUNE = 4;

	public const int CONDITION_ADD_HEAL_IMMUNE = 8;

	public const int CONDITION_ADD_STUN_IMMUNE = 16;

	public const int CONDITION_ADD_SILENCE_IMMUNE = 32;

	public const int CONDITION_ADD_NO_MOVE_IMMUNE = 64;

	public const int CONDITION_ADD_ELITE = 128;

	public const int CONDITION_ADD_BOSS = 256;

	public const int CONDITION_ADD_COMMON = 512;

	public const int INTERUPT_SELF_DEAD = 1;

	public const int INTERUPT_COMPLETE_LEVEL = 2;

	public const int INTERUPT_COMPLETE_BATTLE = 4;

	public const int INTERUPT_CHANGE_WEAPON = 8;

	public const int INTERUPT_HIT = 16;

	public const int INTERUPT_STUN = 32;

	public const int INTERUPT_DISPEL = 64;

	public const int INTERUPT_ATTACK = 128;

	public const int INTERUPT_DAMAGE = 256;

	public const int INTERUPT_WEAPON_SHARP = 512;

	public const int INTERUPT_HERO_COMMON_ATK = 1024;

	public const int INTERUPT_THERESHOLD_POSITIVE = 2048;

	public const int INTERUPT_THERESHOLD_NAGETIVE = 4096;

	public const int TYPE_TAG_ARG1 = 1;

	public const int TYPE_TAG_ARG2 = 2;

	public const int TYPE_TAG_ARG3 = 4;

	public const int TYPE_TAG_ARG4 = 8;

	public const int TYPE_TAG_ARG5 = 16;

	public const int TYPE_TAG_ARG6 = 32;

	public const int TYPE_TAG_ARG7 = 64;

	public const int TYPE_TAG_ARG8 = 128;

	public const int BUFF_OVERLYING_TYPE_RESET = 1;

	public const int BUFF_OVERLYING_TYPE_OVERLY = 2;

	public const int BUFF_OVERLYING_TYPE_NO_IMPACT = 3;

	public const int BUFF_OVERLYING_TYPE_NO_OVERLY = 4;

	public const int BUFF_TYPE_DAMAGE = 1;

	public const int BUFF_TYPE_HEAL = 2;

	public const int BUFF_TYPE_ATTIBUTE = 3;

	public const int BUFF_TYPE_STATE = 4;

	public const int BUFF_TYPE_ATDAMAGE = 7;

	public const int BUFF_TYPE_LIFE_STEAL = 9;

	public const int BUFF_TYPE_MODIFY_DAMAGE = 10;

	public const int BUFF_TYPE_MODIFY_HEAL = 11;

	public const int BUFF_TYPE_DAMAGE_SHIELD = 12;

	public const int BUFF_TYPE_HEAL_SHIELD = 13;

	public const int BUFF_TYEP_SPEED_MOVE = 14;

	public const int BUFF_TYEP_SPEED_ATTACK = 15;

	public const int BUFF_TYEP_SPEED_PAUSE = 16;

	public const int BUFF_TYEP_CRIT_STAR = 17;

	public const int BUFF_TYEP_TOTAL_DAMAGE = 18;

	public const int BUFF_TYEP_CRIT_TIMES = 19;

	public const int BUFF_TYEP_CHANGE_INTERNAL = 20;

	public const int BUFF_TYEP_BUFF_LIFE_LINK = 21;

	public const int BUFF_TYEP_NAGETIVE_DAMAGE_SHILED = 22;

	public const int BUFF_TYEP_ATTRIBUTE_ABSORB = 23;

	public const int BUFF_TYEP_DAMAGE_RESIST = 24;

	public const int BUFF_TYEP_TOTOL_DAMAGE2 = 25;

	public const int BUFF_TYEP_DODGE = 26;

	public const int BUFF_TYPE_DAMAGE_LIMIT = 27;

	public const int BUFF_TYPE_HEAL2 = 28;

	public const int BUFF_TYPE_SHARPCHANGE = 29;

	public const int BUFF_TYEP_DODGE_STAR = 30;

	public const int BUFF_TYEP_DAMAGE_HEAL = 31;

	public const int BUFF_TYPE_BLOODTHRESHOLD = 32;

	public const int BUFF_TYPE_MODIFY_SPECIAL_DAMAGE = 50;

	public const int BUFF_TYPE_MODIFY_SPECIAL_DAMAGE_RERAISE = 51;

	public const int BUFF_TYPE_MODIFY_SPECIAL_DAMAGE_RELIFE = 52;

	public const int BUFF_TYPE_LIFE_LINK_EFFECT = 53;

	public const int BUFF_TYPE_MARK = 99;

	public const int BUFF_TEXT_STUN = 1;

	public const int BUFF_TEXT_SILENCE = 2;

	public const int BUFF_TEXT_NOMOVE = 3;

	public const int BUFF_TEXT_RESIST = 4;

	public const int BUFF_TEXT_LINKLIFE = 5;

	public long ID;

	public bool isWithSpawn;

	public int type;

	public bool isPositive;

	public string buffTempletId;

	public int condition;

	public int replaceType;

	public int replaceLevel;

	public int replaceGroup;

	public int overlyingType;

	public float maxDuration;

	public float triggerDuration;

	public int maxStack;

	public int interputType;

	public int interputTypeHitCount;

	public int interputTypeAttackCount;

	public int interputTypeDamageCount;

	public int effectType;

	public int level;

	public long triggerTriggerSkillID;

	public long triggerInteruptSkillID;

	public long triggerEndSkillID;

	public long triggerSubLayerSkillID;

	public string buffPrefabAdd;

	public string buffPrefabLoop;

	public string buffPrefabTick;

	public string buffPrefabEnd;

	public long[] attached_buff;

	public ParamsVO script;

	public string groupIds;

	public int buffTypeTag;

	public bool isBattlestateNotActive;

	public BuffEffectTPL buffEffectTPL;

	public int interrupted_by_player_normal_attack;

	public int interrupted_by_hp_forward_threshold;

	public int interrupted_by_hp_backward_threshold;

	public static BuffProperty GetBuffByID(long buffID)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public bool isStunBuff()
	{
		return false;
	}

	public bool isSilenceBuff()
	{
		return false;
	}

	public bool isNoMoveBuff()
	{
		return false;
	}

	public bool isNagetiveBuff()
	{
		return false;
	}
}
