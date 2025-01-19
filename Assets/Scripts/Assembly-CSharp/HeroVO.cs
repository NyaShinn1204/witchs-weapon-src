using System.Collections.Generic;

public class HeroVO
{
	private const int FACTOR_COUNT = 100;

	public long ID;

	public int level;

	public PropertiesVO property;

	public long attackSkillID;

	public List<SkillVO> abilities;

	public List<TriggerVO> triggers;

	public float one;

	public float two;

	public float dual;

	public int first_attack_interval_lower;

	public int first_attack_interval_upper;

	public int attack_interval_lower;

	public int attack_interval_upper;

	public List<long> spawnBuffs;

	public List<long> summonBuffs;

	public List<int> spawnBuffsLayer;

	public List<int> summonBuffsLayer;

	public int[] playerAttr;

	public int fashionSN;

	public string fashionPrefab;
}
