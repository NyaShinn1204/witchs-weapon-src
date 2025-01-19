using System;

[Serializable]
public class BuffVO
{
	public const int INTERUPT_TYPE_DEATH = 1;

	public const int INTERUPT_TYPE_END_BATTLE = 2;

	public const int INTERUPT_TYPE_END_KILL_WAVE = 4;

	public const int INTERUPT_TYPE_CHANGE_WEAPON = 8;

	public const int INTERUPT_TYPE_HIT_COUNT = 16;

	public const int INTERUPT_TYPE_BECOME_STUN = 32;

	public long ID;

	public int type;

	public bool isPositive;

	public int replaceType;

	public int replaceLevel;

	public int replaceGroup;

	public int overlyingType;

	public float maxDuration;

	public int maxStack;

	public float triggerDuration;

	public int interputType;

	public int interputTypeHitCount;

	public int effectType;

	public int level;

	public long triggerStartSkillID;

	public long triggerTriggerSkillID;

	public long triggerInteruptSkillID;

	public long triggerEndSkillID;

	public ParamsVO script;
}
