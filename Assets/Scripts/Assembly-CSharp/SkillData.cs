using System;
using WaterBell.ProjX.View.Panel;

[Serializable]
public class SkillData : UIDataBase
{
	public enum DurabilitySteps
	{
		Empty = 0,
		Red = 1,
		Yellow = 2,
		Green = 3
	}

	public enum WeaponModes
	{
		Normal = 0,
		Weapon = 1
	}

	public bool canUseWeaponSkill;

	public WeaponModes weaponMode;

	public bool canPitching;

	public bool isPitching;

	public int power;

	public int power_max;

	public int rank;

	public int star;

	public bool isInBattle;

	public bool isInCommonSkill;

	public int durability;

	public int cacheDurability;

	public DurabilitySteps durabilityStep;

	public int durability_recovery;

	public int durability_max;

	public WeaponSharpInfo sharpInfo;
}
