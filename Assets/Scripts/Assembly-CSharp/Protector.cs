using System.Collections.Generic;

public class Protector
{
	public const int TYPE_BATTLE_START = 10;

	public const int TYPE_BATTLE_END = 11;

	public const int TYPE_BATTLE_ENEMY_COUNT = 12;

	public const int TYPE_COMMON_ATK_COUNT_ENEMY = 21;

	public const int TYPE_ACTIVE_SKILL_INTERVAL = 40;

	public const int TYPE_PROP_BASE = 50;

	public const int TYPE_PROP = 51;

	public const int TYPE_COMMON_ATK_MAX_DAMAGE = 110;

	public const int TYPE_COMMON_ATK_DAMAGE_COUNT = 111;

	public const int TYPE_COMMON_ATK_HALF_MAX_DAMAGE_COUNT = 112;

	public const int TYPE_ACTIVY_SKILL_COUNT = 142;

	public const int TYPE_COMMON_ATK_COUNT_INCREASE = 120;

	public const int TYPE_COMMON_ATK_INTERVAL = 130;

	public const int TYPE_COMMON_ATK_ALL_DAMAGE = 140;

	public const int TYPE_COMMON_ATK_ALL_BLOOD = 141;

	public const int TYPE_MOB_COUNT = 143;

	private static Protector _instance;

	private List<ICheckable> checkList;

	public static Protector Instance()
	{
		return null;
	}

	private void Init()
	{
	}

	public static float GetSystemTime()
	{
		return 0f;
	}

	public void Collect(int TYPE, params object[] param)
	{
	}

	public string CheckAll()
	{
		return null;
	}

	public void Reset()
	{
	}
}
