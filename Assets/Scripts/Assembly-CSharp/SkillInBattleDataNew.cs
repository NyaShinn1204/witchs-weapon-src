using System;

[Serializable]
public class SkillInBattleDataNew
{
	public enum WeaponModes
	{
		Normal = 0,
		Weapon = 1
	}

	public long servantId;

	public long weaponId;

	public int skillIndex;

	public bool canUseWeaponSkill;

	public WeaponModes weaponMode;

	public bool canSwap;

	public bool isPitching;

	public int power;

	public int power_max;

	public int rank;

	public int star;

	public bool isInBattle;

	public bool isInCommonSkill;

	public int durability;

	public int durability_recovery;

	public int durability_max;
}
