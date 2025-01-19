public class SkillProperty
{
	public const int TYPE_COMMON = 1;

	public const int TYPE_ACTIVE = 2;

	public const int TYPE_PASSIVE = 3;

	public const int TYPE_WEAPON = 4;

	public const int RELEASE_TARGET_TYPE_UNIT = 1;

	public const int RELEASE_TARGET_TYPE_POINT = 2;

	public const int RELEASE_TARGET_SELECTION_TYPE_CURRENT = 1;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF = 2;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF_RANGE_NEAREST = 10;

	public const int RELEASE_TARGET_SELECTION_TYPE_TARGET_RANGE_RANDOM = 11;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF_RANGE_RANDOM = 12;

	public const int RELEASE_TARGET_SELECTION_TYPE_TARGET_POINT = 100;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF_POINT = 101;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF_RANGE_RANDOM_POINT = 102;

	public const int RELEASE_TARGET_SELECTION_TYPE_TARGET_RANGE_POINT = 103;

	public const int RELEASE_TARGET_SELECTION_TYPE_SELF_RANGE_POINT = 104;

	public const int RELEASE_TARGET_SELECTION_TYPE_LINE_POINT = 105;

	public const int INTERUPT_SHIFT = 1;

	public const int INTERUPT_STUN = 2;

	public const int INTERUPT_SILENCE = 4;

	public const int INTERUPT_NO_MOVE = 8;

	public const int TARGET_INTERUPT_DEAD = 1;

	public const int TARGET_INTERUPT_FLY = 2;

	public const int TARGET_INTERUPT_DRILL = 4;

	public long id;

	public string effectTemplateID;

	public int priority;

	public bool isCanPush;

	public int SpellType;

	public int SpellCanCastType;

	public int SpellTypeTag;

	public string scriptID;

	public int level;

	public int targetType;

	public int targetType1;

	public int targetTypeNominal;

	public int targetArg1;

	public int targetArg2;

	public int targetArg3;

	public int targetArg4;

	public long targetArg5;

	public int distanceType;

	public float distanceMax;

	public float distanceMaxCast;

	public string specialAnimation;

	public float chargeTime;

	public float warningRangeTime;

	public string chargeStart;

	public string channelStart;

	public string channelEnd;

	public bool chargeBlink;

	public int chargeRangeCenterType;

	public int chargeRangeType;

	public float chargeRangeArg1;

	public float chargeRangeArg2;

	public float chargeRangeArg3;

	public float chargeRangeArg4;

	public int channelInteruptSelf;

	public int channelInteruptTarget;

	public int chargeInteruptSelf;

	public int chargeInteruptTarget;

	public bool chargeCanTrun;

	public bool chennelCanTrun;

	public float channelTime;

	public float cd;

	public bool isFaceToTarget;

	public bool isDriveByAnimation;

	public ParamsVO param;

	public long hitEffects;

	public float loadingTime;

	public long[] linkSkill;

	public bool hasSepcialAnimation;

	public float attackTime;

	public SkillProperty Clone()
	{
		return null;
	}

	public bool CanReleaseValid(Entity entity)
	{
		return false;
	}

	public long GetLinkSpell()
	{
		return 0L;
	}

	public long GetLinkSpell(int i)
	{
		return 0L;
	}

	public override string ToString()
	{
		return null;
	}
}
