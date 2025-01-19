using System;

[Serializable]
public class SkillVO : IComparable
{
	public ParamsVO script;

	public long ID;

	public int priority;

	public int level;

	public int releaseType;

	public float releaseDist;

	public bool isCommon;

	public float cooldownTime;

	public float cooldownMax;

	public long[] neededBuffs;

	public long[] summons;

	public int state;

	public bool isPhysic;

	public bool isNear;

	public bool isSingle;

	public int type;

	public bool isActive;

	public bool isDash;

	public long weaponATK;

	public int typeTag;

	public void SetSkillTypeTag(int typeTag)
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
