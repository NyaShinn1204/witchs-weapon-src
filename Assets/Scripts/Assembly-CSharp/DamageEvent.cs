public class DamageEvent : BaseEvent
{
	public Entity attacker;

	public Entity defencer;

	public bool isCrit;

	public float bloodCut;

	public int typeTag;

	public int damageTag;

	public int damageType;

	public DamageEvent(Entity attacker, bool isCrit, int typeTag, int damageTag, int damageType)
	{
	}
}
