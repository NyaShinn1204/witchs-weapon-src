public class HitEvent : BaseEvent
{
	public Entity attacker;

	public Entity defencer;

	public bool isHit;

	public bool isMiss;

	public bool isCrit;

	public int spellTypeTag;

	public int damageType;

	public HitEvent(Entity attacker, bool isHit, bool isMiss, bool isCrit, int spellTypeTag)
	{
	}
}
