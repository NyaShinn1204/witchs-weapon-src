using WaterBell.Framework.Event;

public class PauseEvent : EventBase
{
	public bool isPause;

	public bool isCausedBySkill;

	public PauseEvent(bool pause, bool isBySkill)
	{
	}
}
