public class DamagePack : BasePack
{
	public const int STEAL_LIFE_COUNTER = 256;

	public const int STEAL_LIFE_LINK = 512;

	public const int OVER_DAMAGE_COUNTER = 8192;

	public Entity attacker;

	public Entity defencer;

	public Entity Source;

	public int camp;

	public NumericResult result;

	public int type;

	public float eatBloodPersent;

	public float eatBloodValue;

	public bool isTriggerEatBlood;

	public bool isCommonAtk;

	public bool isTriggerAttackCounter;

	public bool isTriggerHitCounter;

	public bool isTriggerDamageCounter;

	public bool isTriggerBackHit;

	public int damageTag;

	public int typeTag;

	public float absorbPhysicP;

	public float absorbPhysicV;

	public float absorbMagicP;

	public float absorbMagicV;

	public float absorbAllP;

	public float absorbAllV;

	public bool isStealLife;

	public bool isCombine;

	public bool isBackhit;

	public float damagetohealRate;

	public long cSound;

	public long hitSound;

	public bool showHit;

	public int EventTo;

	public DamagePack(Entity attacker, Entity defencer, int damageTag, int typeTag)
	{
	}

	public DamagePack clone()
	{
		return null;
	}

	public void OnInit()
	{
	}

	private void StatInfo()
	{
	}

	private void DoCheckStealBuffs()
	{
	}

	private void DoCheckDamageToHealBuffs()
	{
	}

	private void DoCheckDamageTotal2Buffs(float pOrigin, float mOrigin, float sOrigin)
	{
	}

	private void DoAttack()
	{
	}

	public static NumericResult ModifyResultByBuff(NumericResult result, BuffModifyDamage buff)
	{
		return null;
	}

	public static NumericResult LimitResultByBuff(NumericResult result, BuffDamageLimit buff)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
