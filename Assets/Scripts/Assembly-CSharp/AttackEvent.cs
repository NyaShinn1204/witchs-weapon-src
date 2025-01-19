public class AttackEvent : BaseEvent
{
	public Entity target;

	public Entity source;

	public bool isHit;

	public bool isMiss;

	public bool isCrit;

	public int spellTypeTag;

	public int damagetype;

	public AttackEvent(Entity target, bool isHit, bool isMiss, bool isCrit, int spellTypeTag, int damagetype)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
