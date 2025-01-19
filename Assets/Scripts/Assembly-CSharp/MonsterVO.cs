using System;
using System.Collections.Generic;

[Serializable]
public class MonsterVO
{
	public const int MONSTER_KIND_SERVANT = 1;

	public const int MONSTER_KIND_ELITE = 2;

	public const int MONSTER_KIND_COMMON = 3;

	public const int MONSTER_POWERRANK_COMMON = 1;

	public const int MONSTER_POWERRANK_ELITE = 2;

	public const int MONSTER_POWERRANK_BOSS = 3;

	public const int FACTOR_COUNT = 10;

	public string uuid;

	public long ID;

	public int level;

	public string model;

	public PropertiesVO property;

	public int powerRank;

	public bool beSelected;

	public int typeFreeAI;

	public bool isAsSummonUnit;

	public int[] factor;

	public List<long> skillIds;

	public List<long> buffIds;

	public List<long> triggers;

	public List<long> spawnBuffs;

	public List<long> spawnTriggers;

	public bool isFollowMaster;

	public float followDistance;

	public bool isNative;

	public List<long> summonBuffList;

	public List<int> summonBuffListLayer;

	public int ajustType;

	public long behaviorTreeID;

	public float first_attack_interval_lower;

	public float first_attack_interval_upper;

	public float attack_interval_lower;

	public float attack_interval_upper;

	public long SummonMob1;

	public long SummonMob2;

	public long SummonMob3;

	public int SummonNum1;

	public int SummonNum2;

	public int SummonNum3;

	public int mob_kind;

	public List<SkillProperty> GetSkillProperties()
	{
		return null;
	}

	public void SetFollow(bool followMaster, float distance)
	{
	}
}
