using WaterBell.Framework.Event;

public class PassiveTrigger
{
	public const int TRIGGER_TYPE_CONST = 1;

	public const int TRIGGER_TYPE_TIMER = 2;

	public const int TRIGGER_TYPE_EVENT = 3;

	public const int TRIGGER_RATE_TYPE_DIRECT = 1;

	public const int TRIGGER_RATE_TYPE_INDIRECT = 2;

	public const int EVENT_TARGET_TYPE_NO_CARE = 0;

	public const int EVENT_TARGET_TYPE_SOURCE_IS_SELF = 1;

	public const int EVENT_TARGET_TYPE_TARGET_IS_SELF = 2;

	public const int EVENT_TARGET_TYPE_SOURCE_TARGET_IS_SELF = 3;

	public const int EVENT_TARGET_TYPE_SOURCE_NOT_SELF = 4;

	public const int EVENT_TARGET_TYPE_TARGET_NOT_SELF = 5;

	public const int EVENT_TARGET_TYPE_SOURCE_TARGET_NOT_SELF = 6;

	public const int EVENT_TARGET_TYPE_SOURCE_IS_ENTITY = 7;

	public const int EVENT_TARGET_TYPE_TARGET_IS_ENTITY = 8;

	public const int EVENT_TARGET_TYPE_SOURCE_NOT_ENTITY = 9;

	public const int EVENT_TARGET_TYPE_TARGET_NOT_ENTITY = 10;

	public const int EVENT_TARGET_TYPE_SOURCE_MASTER_IS_ENTITY = 11;

	public long UUID;

	public long ID;

	private BaseEvent evt;

	public bool isActive;

	public TriggerVO triggerVO;

	public int triggerCount;

	public TriggerManager manager;

	public Entity entity;

	private HitRandom hitRandom;

	private HitRandom hitRandomTH;

	private HitRandom hitRandomDW;

	private HitRandom hitRandomSH;

	public virtual void OnInit(Entity entity, TriggerManager manager)
	{
	}

	public virtual void OnUpdate()
	{
	}

	public virtual void Active()
	{
	}

	public virtual void DeActive()
	{
	}

	public virtual void OnEvent(BaseEvent evt)
	{
	}

	protected void Trigger()
	{
	}

	private void TriggerSkill()
	{
	}

	public static Entity GetEventTarget(EventBase evt)
	{
		return null;
	}

	private void AppendEventTarget(Skill skill, Entity targetEntity)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
