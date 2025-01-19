using System.Collections.Generic;

public class DamagePackProcessor : IPackProcessor
{
	private const int damageType = 3;

	private const int damageTag = 65;

	private const int typeTag = 0;

	private List<DamagePack> damagePackList;

	private Entity entity;

	private List<DamagePack> cache;

	public DamagePackProcessor(Entity target)
	{
	}

	public void Collect(BasePack pack)
	{
	}

	private void ReadCache()
	{
	}

	private void CachePack(DamagePack pack)
	{
	}

	public void Calulate()
	{
	}

	private void StatDamage(Entity monster, float blood)
	{
	}

	private void SendHitEvent(DamagePack pack, float physicDamageOrigin, float magicDamageOrigin, float solidDamageOrigin)
	{
	}

	private void cloneToEventValueParam(EventValueParam valueParam, float pOrigin, float mOrigin, float sOrigin, DamagePack pack)
	{
	}

	private bool CheckLifeLinkBuffs(DamagePack pack)
	{
		return false;
	}

	private DamagePack LifeLinkBuffDamageTag(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckResultBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckModifyBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckLimitBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckSpecialModifyBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckImmue(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckDamageResistBuffs(Entity entity, DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckAbsorbReduceBuffs(Entity entity, DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckAbsorbBuffs(Entity entity, DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckStealLifeBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckBackHitBuffs(DamagePack pack)
	{
		return null;
	}

	private DamagePack CheckDamagetoHealBuffs(DamagePack pack, int overdamage)
	{
		return null;
	}

	private DamagePack CheckDamageTotal2Buffs(DamagePack pack, float pOrigin, float mOrigin, float sOrigin)
	{
		return null;
	}

	public void Reset()
	{
	}
}
