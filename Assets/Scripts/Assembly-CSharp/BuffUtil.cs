public class BuffUtil
{
	public static BuffEntity AddBuff(long buffID, int level, Entity entity, Entity source, BuffSourcePropDTO buffSourceVO, int layer = 1, BuffDefined buffdefined = null)
	{
		return null;
	}

	private static bool checkAddCondition(BuffProperty buffVo, Entity entity)
	{
		return false;
	}

	public static BuffEntity GetBuff(long buffId, Entity unit)
	{
		return null;
	}

	public static BuffEntity[] GetAllBuffComponents(Entity entity)
	{
		return null;
	}

	public static BuffEntity[] GetAllBuffComponentsFromCache(Entity entity)
	{
		return null;
	}

	public static void RemoveBuff(long buffId, Entity entity)
	{
	}

	public static void RemoveAllBuffs(Entity entity)
	{
	}

	public static void BreakAllBuffs(Entity unit)
	{
	}

	public static void PauseAllBuffs(Entity unit)
	{
	}

	private static BuffEntity AddBuffComponent(long buffId, Entity unit, int layerCount, Entity source, BuffSourcePropDTO buffSourceVO, BuffDefined buffdefined)
	{
		return null;
	}

	private static BuffEntity OverlayOrReplace(BuffEntity[] buffs, long buffId, Entity unit, int layerCount, Entity source, BuffSourcePropDTO buffSourcVO, BuffDefined buffdefined)
	{
		return null;
	}

	public static BuffEntity CreateNewBuffComponent(long buffID, Entity entity, int layerCount, Entity source, BuffSourcePropDTO buffSourceVO, BuffDefined buffdefined)
	{
		return null;
	}

	public static void ShowBuffInfo(int type, Entity entity, Entity soure)
	{
	}

	private static BuffEntity GetBuffByType(int type, Entity entity)
	{
		return null;
	}
}
