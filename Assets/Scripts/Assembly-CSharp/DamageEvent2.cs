public class DamageEvent2 : BaseEvent
{
	public Entity attacker;

	public Entity defencer;

	public Entity source;

	public bool isCrit;

	public float bloodCut;

	public int typeTag;

	public int damageTag;

	public int damageType;

	public DamageEvent2(Entity attacker, bool isCrit, int typeTag, int damageTag, int damagetype)
	{
	}
}
