public static class NumberCalulater
{
	public const int TYPE_PHSICAL = 1;

	public const int TYPE_MAGIC = 2;

	public const int TYPE_SOLID = 4;

	public static NumericResult DoDamage(Entity attacker, Entity defencer, NumericParam param, int type, float damageRate, int packLevel, PackParam packParam, bool isCommonAtk = false, BuffSourcePropDTO buffSourceVO = null)
	{
		return null;
	}

	private static float CheckCritHighBuffs(Entity entity, float FPCM, bool isCommonAtk)
	{
		return 0f;
	}

	public static float DoHeal(Entity attacker, Entity defencer, NumericParam param, float healRate, BuffSourcePropDTO buffSourceVO = null)
	{
		return 0f;
	}

	public static float FMR(PropertiesVO attackerProp, int attackerLevel, Entity defencer, NumericParam param, int packLevel, int camp)
	{
		return 0f;
	}

	public static float FDR(PropertiesVO attackerProp, int attackerLevel, Entity defencer, NumericParam param, int packLevel, int camp)
	{
		return 0f;
	}

	public static float FSPHR(PropertiesVO attackerProp, int attackerLevel, Entity defencer, NumericParam param, int packLevel, int camp)
	{
		return 0f;
	}

	public static float FPCR(PropertiesVO attackerProp, int attackerLevel, Entity defencer, NumericParam param, int packLevel, int camp)
	{
		return 0f;
	}

	public static float FMCR(PropertiesVO attackerProp, int attackerLevel, Entity defencer, NumericParam param, int packLevel, int camp)
	{
		return 0f;
	}
}
