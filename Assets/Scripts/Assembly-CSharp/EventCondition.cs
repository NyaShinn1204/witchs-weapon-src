using WaterBell.Framework.Event;

public class EventCondition
{
	public const int EVENT_TYEP_SKILL = 1;

	public const int EVENT_TYEP_ATTACK = 10;

	public const int EVENT_TYEP_HIT = 11;

	public const int EVENT_TYEP_DAMAGE = 12;

	public const int EVENT_TYEP_HEAL = 13;

	public const int EVENT_TYEP_DAMAGE2 = 14;

	public const int EVENT_TYPE_WEAPONSHARP = 200;

	public const int EVENT_TYPE_WEAPONSHARP_RED = 201;

	public const int EVENT_TYPE_WEAPONSHARP_YELLOW = 202;

	public const int EVENT_TYPE_WEAPONSHARP_GREEN = 203;

	public const int EVENT_TYPE_WEAPONSHARP_CHANGE = 204;

	public const int EVENT_TYEP_SPAWN = 1000;

	public const int EVENT_TYEP_DEAD = 1001;

	public const int EVENT_TYEP_DEAD_END = 1002;

	public const int TRIGGER_TYPE_NONE = 0;

	public const int TRIGGER_TYPE_YES = 1;

	public const int TRIGGER_TYPE_NO = 2;

	public const int TRIGGER_TYPE_ALL = 3;

	public int type;

	public long arg0;

	public long arg1;

	public int arg2;

	public int arg3;

	public int arg4;

	public int arg5;

	public int arg6;

	public int arg7;

	public int arg8;

	public Entity entity;

	public PassiveTrigger trigger;

	public Entity eventSource;

	public Entity eventTarget;

	public EventCondition()
	{
	}

	public EventCondition(Entity entity)
	{
	}

	public EventCondition(Entity entity, int type, long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
	}

	public bool IsEquals(EventCondition eventCondition)
	{
		return false;
	}

	private bool CheckEventTypeValid(Entity eventSource, Entity eventTarget)
	{
		return false;
	}

	private bool CanTrigger(long eventConditionArg, long type)
	{
		return false;
	}

	public static EventCondition CreateFromEvent(EventBase evt)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
