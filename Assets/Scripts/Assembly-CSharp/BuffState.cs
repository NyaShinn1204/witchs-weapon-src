public class BuffState : BuffEntity
{
	public const int TAG_BUFF_NAGTIVE = 1;

	public const int TAG_PHYSIC_IMMUE = 2;

	public const int TAG_MAGIC_IMMUE = 4;

	public const int TAG_HEAL_IMMUE = 8;

	public const int TAG_STUN_IMMUE = 16;

	public const int TAG_SLIENCE_IMMUE = 32;

	public const int TAG_NO_MOVE_IMMUE = 64;

	public const int TAG_PASSIVE_SHIFT_IMMUE = 128;

	public const int TAG_DEATH_IMMUE = 256;

	public const int TAG_NO_DEATH = 512;

	public const int TAG_ALL_IMMUE = 1024;

	public const int TAG_NOT_STUN_PASSIVE_SHIFT_IMMUE = 2048;

	public const int TAG_NOT_CHANGE_WWAPON = 4096;

	public const int TAG_LOCK_SHARP = 8192;

	public const int TAG_FEAR_IMMUE = 16384;

	public const int TYPE_STUN_ICE = 1;

	public const int TYPE_STUN_STONE = 2;

	public const int TYPE_STUN_TIME = 3;

	public const int TYPE_STUN_FLY = 4;

	public const int TYPE_STUN_STUN = 5;

	public const int TYPE_STUN_SLEEP = 6;

	public const int TYPE_STUN_AFRAID = 7;

	public const int TYPE_STUN_ABSTRACT = 8;

	public int stunType;

	public int slienceType;

	public int noMoveType;

	public int otherState;

	public int basicValue;

	public int growValue;

	public bool entitycannotChoose;

	public bool entitycannotChoose_old;

	private bool isAddStun;

	private bool isAddSlience;

	private bool isAddNoMove;

	private long lockweaponid;

	public override void OnStart()
	{
	}

	private void AddStun()
	{
	}

	public override BuffEntity OverLying(long protoBuffID, int layerCount, Entity unit, Entity soruce, BuffSourcePropDTO buffSourceVO, BuffDefined buffDefined)
	{
		return null;
	}

	private void HitFly()
	{
	}

	private void AddSlience()
	{
	}

	private void AddNoMove()
	{
	}

	private void RemoveNoMove()
	{
	}

	private void SubStun()
	{
	}

	private void SubSlience()
	{
	}

	private void SubNoMove()
	{
	}

	private void SubSelect()
	{
	}

	public override void OnDestory()
	{
	}
}
