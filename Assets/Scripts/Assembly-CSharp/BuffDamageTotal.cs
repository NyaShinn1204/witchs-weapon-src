public class BuffDamageTotal : BuffEntity
{
	public const int TYPE_ATTACK_EVENT = 1;

	public const int TYPE_DAMAGE_EVENT = 2;

	public const int TYPE_PHYSIC = 1;

	public const int TYPE_MAGIC = 2;

	public const int TYPE_CONFIRM = 3;

	public const int TYPE_ORIGIN = 1;

	public const int TYPE_FINALE = 2;

	private long SKillID;

	public int type;

	public int category;

	public int category2;

	private float rate;

	private int basic;

	private int grow;

	private float total;

	private float Tdmg;

	private bool containerSelf;

	private bool flushDamage;

	public override void OnStart()
	{
	}

	public override void OnEvent(BaseEvent evt)
	{
	}

	private void OnAttackEvent(BaseEvent evt)
	{
	}

	private void OnDamageEvent(BaseEvent evt)
	{
	}

	private void releseskill(float _total, float _tdmg)
	{
	}
}
