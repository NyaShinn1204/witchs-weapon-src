public class SkillEvent : BaseEvent
{
	public const int TYPE_SKILL_START = 1;

	public const int TYPE_SKILL_END = 2;

	public long skillID;

	public int type;

	public int typeTag;

	public Entity source;

	public Entity target;

	public SkillEvent(long skillID, int type)
	{
	}
}
