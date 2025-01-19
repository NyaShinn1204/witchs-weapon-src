using System.Collections.Generic;

public class BuffGroup
{
	public const int GROUP_COUNT = 13;

	public const char SPLIT_SYMBAL = '|';

	public const int GROUP_NAME_DISPEL = 1;

	public const int GROUP_NAME_POSITIVE_DAMAGE_MODIFY = 2;

	public const int GROUP_NAME_NAGETIVE_DAMAGE_MODIFY = 3;

	public const int GROUP_NAME_POSITIVE_HEAL_MODIFY = 4;

	public const int GROUP_NAME_NAGETIVE_HEAL_MODIFY = 5;

	public const int GROUP_NAME_POSITIVE_DAMAGE_EFFECT = 6;

	public const int GROUP_NAME_NAGETIVE_DAMAGE_EFFECT = 7;

	public const int GROUP_NAME_POSITIVE_HEAL_EFFECT = 8;

	public const int GROUP_NAME_NAGETIVE_HEAL_EFFECT = 9;

	public const int GROUP_NAME_MARK = 10;

	public const int GROUP_LIFE_LINK = 11;

	public const int GROUP_BUFF_CREATE = 12;

	public const int GROUP_RESULT_MODIFY = 13;

	public List<Dictionary<long, BuffEntity>> subGroups;

	public Dictionary<long, BuffEntity> GetBuffGroup(int groupName)
	{
		return null;
	}

	public static BuffGroup CreateBuffGroup(Entity unit)
	{
		return null;
	}

	public void AddBuff(BuffEntity buff)
	{
	}

	public void RemoveBuff(BuffEntity buff)
	{
	}
}
