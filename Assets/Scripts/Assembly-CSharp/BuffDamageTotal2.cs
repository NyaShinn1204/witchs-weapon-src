public class BuffDamageTotal2 : BuffEntity
{
	public const int TYPE_ATTACK_EVENT = 1;

	public const int TYPE_DAMAGE_EVENT = 2;

	public const int TYPE_PHYSIC = 1;

	public const int TYPE_MAGIC = 2;

	public const int TYPE_CONFIRM = 3;

	public const int TYPE_ORIGIN = 1;

	public const int TYPE_FINALE = 2;

	public int type;

	public int category;

	public int category2;

	public float total;

	public bool containerSelf;

	public override void OnStart()
	{
	}

	public void AppendValue(float physicDamage, float magicDamage, float solidDamage, float physicDamageOrigin, float magicDamageOrigin, float solidDamageOrigin)
	{
	}
}
